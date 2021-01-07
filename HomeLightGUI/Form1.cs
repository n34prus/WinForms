using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeLightGUI
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (Globals.firstTime)                              //при инициализации связи
            {
                UART.WriteByteToBufferTX((byte)(02), 0);        //запрашиваем текущий цвет
                UART.SendBufferTX();
            }

            UART.RecieveMessage();                                          //принимаем пакет из UART
            valueDATA0rx.Text = UART.GetByteFromBufferRX(0).ToString();     //отображаем его во вкладке разработчика
            valueDATA1rx.Text = UART.GetByteFromBufferRX(1).ToString();
            valueDATA2rx.Text = UART.GetByteFromBufferRX(2).ToString();
            valueDATA3rx.Text = UART.GetByteFromBufferRX(3).ToString();
            valueDATA4rx.Text = UART.GetByteFromBufferRX(4).ToString();
            valueDATA5rx.Text = UART.GetByteFromBufferRX(5).ToString();
            valueDATA6rx.Text = UART.GetByteFromBufferRX(6).ToString();
            valueDATA7rx.Text = UART.GetByteFromBufferRX(7).ToString();

            if ((UART.GetByteFromBufferRX(0) == 2)&&(Globals.firstTime))    //при инициализации связи если получили команду 02
            {
                Globals.firstTime = false;                                  //считаем что инициализация связи прошла успешно 
                updateColourFromUART();                                     //обновляем вкладку с цветом (возможно нет смысла проверять первый раз)
            }

            if (!Globals.firstTime)                                                 //после инициализации связи
            {
                UART.WriteByteToBufferTX((byte)(01), 0);                            //всё время шлем новый цвет (потом поменять на "если находимся на вкладке "цвет")
                UART.WriteByteToBufferTX((byte)(trackBarRed.Value * 5), 1);
                UART.WriteByteToBufferTX((byte)(trackBarGreen.Value * 5), 2);
                UART.WriteByteToBufferTX((byte)(trackBarBlue.Value * 5), 3);
                UART.SendBufferTX();
            }
        }

        private void MyForm_FormClosed(object sender, FormClosedEventArgs e)    //убиваем все потоки
        {
            Environment.Exit(0);
        }

        private void buttonSend_Click(object sender, EventArgs e)               //нажали на кнопку "отправить"
        {
            UART.WriteByteToBufferTX(byte.Parse(textBoxData0tx.Text), 0);       //закидываем в буфер содержимое полей
            UART.WriteByteToBufferTX(byte.Parse(textBoxData1tx.Text), 1);
            UART.WriteByteToBufferTX(byte.Parse(textBoxData2tx.Text), 2);
            UART.WriteByteToBufferTX(byte.Parse(textBoxData3tx.Text), 3);
            UART.WriteByteToBufferTX(byte.Parse(textBoxData4tx.Text), 4);
            UART.WriteByteToBufferTX(byte.Parse(textBoxData5tx.Text), 5);
            UART.WriteByteToBufferTX(byte.Parse(textBoxData6tx.Text), 6);
            labelCRCValue.Text = UART.SendBufferTX().ToString();                //отправляем буфер, выводим CRC
        }

        private void MyForm_Load(object sender, EventArgs e)    //при запуске
        {

        }

        private void trackBarAny_Scroll(object sender, EventArgs e)
        {
            textBoxRed.Text = ((byte)(trackBarRed.Value * 5)).ToString();
            textBoxGreen.Text = ((byte)(trackBarGreen.Value * 5)).ToString();
            textBoxBlue.Text = ((byte)(trackBarBlue.Value * 5)).ToString();
        }

        private void textBoxAny_TextChanged(object sender, EventArgs e)
        {
            trackBarRed.Value = (byte)(Int32.Parse(textBoxRed.Text)/5);
            trackBarGreen.Value = (byte)(Int32.Parse(textBoxGreen.Text)/5);
            trackBarBlue.Value = (byte)(Int32.Parse(textBoxBlue.Text)/5);
        }

        private void updateColourFromUART()
        {
            textBoxRed.Text = UART.GetByteFromBufferRX(1).ToString();
            textBoxGreen.Text = UART.GetByteFromBufferRX(2).ToString();
            textBoxBlue.Text = UART.GetByteFromBufferRX(3).ToString();
            trackBarRed.Value = (byte)(UART.GetByteFromBufferRX(1) / 5);
            trackBarGreen.Value = (byte)(UART.GetByteFromBufferRX(2) / 5);
            trackBarBlue.Value = (byte)(UART.GetByteFromBufferRX(3) / 5);
        }
    }
}
