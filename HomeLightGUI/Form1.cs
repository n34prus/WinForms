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

        private void UpdateTimer_Tick(object sender, EventArgs e)   //таймер 100мс
        {
            UART.RecieveMessage();                                          //принимаем пакет из UART
            updateDevText();                                                //отображаем его во вкладке разработчика

            switch (tabControl.SelectedIndex)                           //управление действиями в зависимости от выбранной вкладки
            {
                //ЦВЕТ
                case 0:                   
                    UpdateTimer.Interval = 100;                         //10Гц
                    if (Globals.firstTime)                              //при инициализации связи
                    {
                        UART.WriteByteToBufferTX((byte)(02), 0);        //запрашиваем текущий цвет
                        UART.SendBufferTX();
                    }
                    else                                               //после инициализации связи
                    {
                        UART.WriteByteToBufferTX((byte)(01), 0);                            //всё время шлем новый цвет
                        UART.WriteByteToBufferTX((byte)(trackBarRed.Value * 5), 1);
                        UART.WriteByteToBufferTX((byte)(trackBarGreen.Value * 5), 2);
                        UART.WriteByteToBufferTX((byte)(trackBarBlue.Value * 5), 3);
                        UART.WriteByteToBufferTX((byte)(trackBarWhite.Value * 5), 4);
                        UART.WriteByteToBufferTX((byte)(trackBarBlack.Value * 5), 5);
                        UART.WriteByteToBufferTX((byte)(trackBarSpeed.Value * 5), 6);
                        UART.SendBufferTX();
                    }
                    break;
                //ВРЕМЯ
                case 1:
                    UpdateTimer.Interval = 200;                         //50Гц
                    //обновляем системное время и выводим во вкладку "время"
                    TIME.updateSysTimeBuffer();
                    updateSystemTime();

                    //запрашиваем время модуля и ответ выводим во вкладку "время"
                    Globals.counter_tabTIME++;
                    if (Globals.counter_tabTIME > 3) Globals.counter_tabTIME = 0;
                    switch (Globals.counter_tabTIME)
                    {
                        case 0:
                            UART.WriteByteToBufferTX((byte)(12), 0);        //запрашиваем текущее время
                            break;
                        case 1:
                            UART.WriteByteToBufferTX((byte)(14), 0);        //дату
                            break;
                        case 2:
                            UART.WriteByteToBufferTX((byte)(22), 0);        //недельный будильник
                            break;
                        case 3:
                            UART.WriteByteToBufferTX((byte)(24), 0);        //однократный будильник
                            break;
                    }

                    UART.SendBufferTX();
                    break;
            }

            switch (UART.GetByteFromBufferRX(0))        //когда приняли пакет, проверяем команду
            {
                case 2:
                    if (Globals.firstTime)
                    {
                        Globals.firstTime = false;                  //считаем что инициализация связи прошла успешно 
                        updateColourFromUART();
                    }
                    break;
                case 12:
                    updateModuleTime();
                    break;
                case 14:
                    updateModuleDate();
                    break;
                case 22:
                    updateModuleWA();
                    break;
                case 24:
                    //updateModuleTA();
                    break;
            }

        }

        private void updateModuleWA()
        {
            if (UART.GetByteFromBufferRX(1) == 1) checkedListBoxWAEnable.ForeColor = Color.FromArgb(50, 255, 50);
            else checkedListBoxWAEnable.ForeColor = Color.FromArgb(255, 50, 50);

            labelWASCurrent.Text = "";
            if (UART.GetByteFromBufferRX(4).ToString().Length < 2) labelWASCurrent.Text += "0";
            labelWASCurrent.Text += UART.GetByteFromBufferRX(4).ToString();
            labelWASCurrent.Text += ":";
            if (UART.GetByteFromBufferRX(3).ToString().Length < 2) labelWASCurrent.Text += "0";
            labelWASCurrent.Text += UART.GetByteFromBufferRX(3).ToString();

            labelWAECurrent.Text = "";
            if (UART.GetByteFromBufferRX(6).ToString().Length < 2) labelWAECurrent.Text += "0";
            labelWAECurrent.Text += UART.GetByteFromBufferRX(6).ToString();
            labelWAECurrent.Text += ":";
            if (UART.GetByteFromBufferRX(5).ToString().Length < 2) labelWAECurrent.Text += "0";
            labelWAECurrent.Text += UART.GetByteFromBufferRX(5).ToString(); 

        }
        private void updateSystemTime()
        {
            labelSystemTime.Text = "";
            for (int i = 0; i < 3; i++)
            {
                if (TIME.bufferSysTime[2 - i].ToString().Length == 1) labelSystemTime.Text += "0";
                labelSystemTime.Text += TIME.bufferSysTime[2 - i].ToString();
                if (i < 2) labelSystemTime.Text += ":";
            }
            labelSystemDate.Text = "";
            for (int i = 0; i < 3; i++)
            {
                if (TIME.bufferSysTime[i + 3].ToString().Length == 1) labelSystemDate.Text += "0";
                labelSystemDate.Text += TIME.bufferSysTime[i + 3].ToString();
                if (i < 2) labelSystemDate.Text += " / ";
                else labelSystemDate.Text += "  ";
            }
            if (TIME.bufferSysTime[6] < 7) labelSystemDate.Text += TIME.daysOfWeek[TIME.bufferSysTime[6]];
        }

        private void updateModuleTime()
        {
            labelModuleTime.Text = "";
            for (int i = 1; i < 4; i++)
            {
                if (UART.GetByteFromBufferRX(4 - i).ToString().Length == 1) labelModuleTime.Text += "0";
                labelModuleTime.Text += UART.GetByteFromBufferRX(4 - i).ToString();
                if (i < 3) labelModuleTime.Text += ":";
            }
        }
        private void updateModuleDate()
        { 
            labelModuleDate.Text = "";
            for (int i = 1; i < 4; i++)
            {
                if (UART.GetByteFromBufferRX(i).ToString().Length == 1) labelModuleDate.Text += "0";
                labelModuleDate.Text += UART.GetByteFromBufferRX(i).ToString();
                if (i < 3) labelModuleDate.Text += " / ";
                else labelModuleDate.Text += "  ";
            }
            if (UART.GetByteFromBufferRX(4) < 7) labelModuleDate.Text += TIME.daysOfWeek[UART.GetByteFromBufferRX(4)];
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
        private void updateDevText()
        {
            valueDATA0rx.Text = UART.GetByteFromBufferRX(0).ToString();     //отображаем его во вкладке разработчика
            valueDATA1rx.Text = UART.GetByteFromBufferRX(1).ToString();
            valueDATA2rx.Text = UART.GetByteFromBufferRX(2).ToString();
            valueDATA3rx.Text = UART.GetByteFromBufferRX(3).ToString();
            valueDATA4rx.Text = UART.GetByteFromBufferRX(4).ToString();
            valueDATA5rx.Text = UART.GetByteFromBufferRX(5).ToString();
            valueDATA6rx.Text = UART.GetByteFromBufferRX(6).ToString();
            valueDATA7rx.Text = UART.GetByteFromBufferRX(7).ToString();
        }

        /*              действия пользователя           */

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
        private void buttonSyncTime_Click(object sender, EventArgs e)
        {
            UART.WriteByteToBufferTX(11, 0);
            for (int i = 0; i < 3; i++) UART.WriteByteToBufferTX(TIME.bufferSysTime[i], i + 1);
            labelCRCValue.Text = UART.SendBufferTX().ToString();                //отправляем буфер, выводим CRC
            UART.WriteByteToBufferTX(13, 0);
            for (int i = 0; i < 4; i++) UART.WriteByteToBufferTX(TIME.bufferSysTime[i+3], i + 1);
            labelCRCValue.Text = UART.SendBufferTX().ToString();                //отправляем буфер, выводим CRC
        }

    }
}
