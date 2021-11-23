using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace HomeLightGUI
{
    public partial class MyForm : Form
    {
        //public SerialPort _port;      //объект: port
        public MyForm()
        {
            InitializeComponent();
            while (!Globals.portIsOpen) { }
            UpdateTimer.Start();
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
                    if (Globals.flagFirstStart)                              //при инициализации связи
                    {
                        UART.WriteByteToBufferTX((byte)(02), 0);        //запрашиваем текущий цвет1
                        UART.SendBufferTX();
                        UART.WriteByteToBufferTX((byte)(04), 0);        //запрашиваем текущий цвет2
                        UART.SendBufferTX();
                    }
                    else                                               //после инициализации связи
                    {
                        UpdateTimer.Interval = 300;
                        UART.WriteByteToBufferTX((byte)(01), 0);                            //всё время шлем новый цвет
                        UART.WriteByteToBufferTX((byte)(trackBarRed1.Value * 5), 1);
                        UART.WriteByteToBufferTX((byte)(trackBarGreen1.Value * 5), 2);
                        UART.WriteByteToBufferTX((byte)(trackBarBlue1.Value * 5), 3);
                        UART.WriteByteToBufferTX((byte)(trackBarWhite1.Value * 5), 4);
                        UART.WriteByteToBufferTX((byte)(trackBarBlack1.Value * 5), 5);
                        UART.WriteByteToBufferTX((byte)(trackBarSpeed1.Value * 5), 6);
                        UART.SendBufferTX();
                        UART.WriteByteToBufferTX((byte)(03), 0);                            //всё время шлем новый цвет
                        UART.WriteByteToBufferTX((byte)(trackBarRed2.Value * 5), 1);
                        UART.WriteByteToBufferTX((byte)(trackBarGreen2.Value * 5), 2);
                        UART.WriteByteToBufferTX((byte)(trackBarBlue2.Value * 5), 3);
                        UART.WriteByteToBufferTX((byte)(trackBarWhite2.Value * 5), 4);
                        UART.WriteByteToBufferTX((byte)(trackBarBlack2.Value * 5), 5);
                        UART.WriteByteToBufferTX((byte)(trackBarSpeed2.Value * 5), 6);
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
                            if (Globals.flagUpdateAlarm) UART.WriteByteToBufferTX((byte)(22), 0);        //недельный будильник
                            break;
                        case 3:
                            if (Globals.flagUpdateAlarm) UART.WriteByteToBufferTX((byte)(24), 0);        //однократный будильник
                            Globals.flagUpdateAlarm = false;
                            break;
                    }

                    UART.SendBufferTX();
                    break;
            }

            switch (UART.GetByteFromBufferRX(0))        //когда приняли пакет, проверяем команду
            {
                case 2:
                    if (Globals.flagFirstStart)
                    {
                        //Globals.firstTime = false;                  //инициализация происходит в четвертом кейсе
                        updateColourFromUART1();
                    }
                    break;
                case 4:
                    if (Globals.flagFirstStart)
                    {
                        Globals.flagFirstStart = false;                  //считаем что инициализация связи прошла успешно 
                        updateColourFromUART2();
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

        private void updateModuleWA()   //обновляем данные морды о будильнике
        {
            if (UART.GetByteFromBufferRX(1) == 1)   //ставим галочку enable
            {
                checkedListBoxWAEnable.ForeColor = Color.FromArgb(50, 255, 50);
                checkedListBoxWAEnable.SetItemChecked(0, true);
            }
            else
            {
                checkedListBoxWAEnable.ForeColor = Color.FromArgb(255, 50, 50);
                checkedListBoxWAEnable.SetItemChecked(0, false);
            }

            for (int i=0; i<7; i++)     //ставим галочки на днях
            {
                if (((UART.GetByteFromBufferRX(2) >> i) & 1) == 1) checkedListBoxWADays.SetItemChecked(i, true);
                else checkedListBoxWADays.SetItemChecked(i, false);
            }

            //рисуем wake up current time
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

            //рисуем wake up target time также как и current чтобы потом меньше с этим ебаться
            textBoxWASHour.Text = "";
            if (UART.GetByteFromBufferRX(4).ToString().Length < 2) textBoxWASHour.Text += "0";
            textBoxWASHour.Text += UART.GetByteFromBufferRX(4).ToString();
            textBoxWASMinute.Text = "";
            if (UART.GetByteFromBufferRX(3).ToString().Length < 2) textBoxWASMinute.Text += "0";
            textBoxWASMinute.Text += UART.GetByteFromBufferRX(3).ToString();

            textBoxWAEHour.Text = "";
            if (UART.GetByteFromBufferRX(6).ToString().Length < 2) textBoxWAEHour.Text += "0";
            textBoxWAEHour.Text += UART.GetByteFromBufferRX(6).ToString();
            textBoxWAEMinute.Text = "";
            if (UART.GetByteFromBufferRX(5).ToString().Length < 2) textBoxWAEMinute.Text += "0";
            textBoxWAEMinute.Text += UART.GetByteFromBufferRX(5).ToString();

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
        private void updateColourFromUART1()
        {
            textBoxRed1.Text = UART.GetByteFromBufferRX(1).ToString();
            textBoxGreen1.Text = UART.GetByteFromBufferRX(2).ToString();
            textBoxBlue1.Text = UART.GetByteFromBufferRX(3).ToString();
            textBoxWhite1.Text = UART.GetByteFromBufferRX(4).ToString();
            textBoxBlack1.Text = UART.GetByteFromBufferRX(5).ToString();
            textBoxSpeed1.Text = UART.GetByteFromBufferRX(6).ToString();

            trackBarRed1.Value = (byte)(UART.GetByteFromBufferRX(1) / 5);
            trackBarGreen1.Value = (byte)(UART.GetByteFromBufferRX(2) / 5);
            trackBarBlue1.Value = (byte)(UART.GetByteFromBufferRX(3) / 5);
            trackBarWhite1.Value = (byte)(UART.GetByteFromBufferRX(4) / 5);
            trackBarBlack1.Value = (byte)(UART.GetByteFromBufferRX(5) / 5);
            trackBarSpeed1.Value = (byte)(UART.GetByteFromBufferRX(6) / 5);
        }

        private void updateColourFromUART2()
        {
            textBoxRed2.Text = UART.GetByteFromBufferRX(1).ToString();
            textBoxGreen2.Text = UART.GetByteFromBufferRX(2).ToString();
            textBoxBlue2.Text = UART.GetByteFromBufferRX(3).ToString();
            textBoxWhite2.Text = UART.GetByteFromBufferRX(4).ToString();
            textBoxBlack2.Text = UART.GetByteFromBufferRX(5).ToString();
            textBoxSpeed2.Text = UART.GetByteFromBufferRX(6).ToString();

            trackBarRed2.Value = (byte)(UART.GetByteFromBufferRX(1) / 5);
            trackBarGreen2.Value = (byte)(UART.GetByteFromBufferRX(2) / 5);
            trackBarBlue2.Value = (byte)(UART.GetByteFromBufferRX(3) / 5);
            trackBarWhite2.Value = (byte)(UART.GetByteFromBufferRX(4) / 5);
            trackBarBlack2.Value = (byte)(UART.GetByteFromBufferRX(5) / 5);
            trackBarSpeed2.Value = (byte)(UART.GetByteFromBufferRX(6) / 5);
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
            textBoxRed1.Text = ((byte)(trackBarRed1.Value * 5)).ToString();
            textBoxGreen1.Text = ((byte)(trackBarGreen1.Value * 5)).ToString();
            textBoxBlue1.Text = ((byte)(trackBarBlue1.Value * 5)).ToString();
            textBoxWhite1.Text = ((byte)(trackBarWhite1.Value * 5)).ToString();
            textBoxBlack1.Text = ((byte)(trackBarBlack1.Value * 5)).ToString();
            textBoxSpeed1.Text = ((byte)(trackBarSpeed1.Value * 5)).ToString();

            textBoxRed2.Text = ((byte)(trackBarRed2.Value * 5)).ToString();
            textBoxGreen2.Text = ((byte)(trackBarGreen2.Value * 5)).ToString();
            textBoxBlue2.Text = ((byte)(trackBarBlue2.Value * 5)).ToString();
            textBoxWhite2.Text = ((byte)(trackBarWhite2.Value * 5)).ToString();
            textBoxBlack2.Text = ((byte)(trackBarBlack2.Value * 5)).ToString();
            textBoxSpeed2.Text = ((byte)(trackBarSpeed2.Value * 5)).ToString();
        }

        private void textBoxAny_TextChanged(object sender, EventArgs e)
        {
            trackBarRed1.Value = (byte)(Int32.Parse(textBoxRed1.Text)/5);
            trackBarGreen1.Value = (byte)(Int32.Parse(textBoxGreen1.Text)/5);
            trackBarBlue1.Value = (byte)(Int32.Parse(textBoxBlue1.Text)/5);
            trackBarWhite1.Value = (byte)(Int32.Parse(textBoxWhite1.Text) / 5);
            trackBarBlack1.Value = (byte)(Int32.Parse(textBoxBlack1.Text) / 5);
            trackBarSpeed1.Value = (byte)(Int32.Parse(textBoxSpeed1.Text) / 5);

            trackBarRed2.Value = (byte)(Int32.Parse(textBoxRed2.Text) / 5);
            trackBarGreen2.Value = (byte)(Int32.Parse(textBoxGreen2.Text) / 5);
            trackBarBlue2.Value = (byte)(Int32.Parse(textBoxBlue2.Text) / 5);
            trackBarWhite2.Value = (byte)(Int32.Parse(textBoxWhite2.Text) / 5);
            trackBarBlack2.Value = (byte)(Int32.Parse(textBoxBlack2.Text) / 5);
            trackBarSpeed2.Value = (byte)(Int32.Parse(textBoxSpeed2.Text) / 5);
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

        private void buttonWASet_Click(object sender, EventArgs e)
        {
            UART.WriteByteToBufferTX(21, 0);
            byte days = 0;
            for (int i=0; i<7; i++) days |= (byte)((Convert.ToInt32(checkedListBoxWADays.GetItemChecked(i))) << i);
            UART.WriteByteToBufferTX((byte)(Convert.ToInt32(checkedListBoxWAEnable.GetItemChecked(0))), 1);
            UART.WriteByteToBufferTX(days, 2);
            UART.WriteByteToBufferTX((byte)(Int32.Parse(textBoxWASMinute.Text)), 3);
            UART.WriteByteToBufferTX((byte)(Int32.Parse(textBoxWASHour.Text)), 4);
            UART.WriteByteToBufferTX((byte)(Int32.Parse(textBoxWAEMinute.Text)), 5);
            UART.WriteByteToBufferTX((byte)(Int32.Parse(textBoxWAEHour.Text)), 6);
            labelCRCValue.Text = UART.SendBufferTX().ToString();                //отправляем буфер, выводим CRC
            Globals.flagUpdateAlarm = true;
        }

        private void tabControl_TabIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1) Globals.flagUpdateAlarm = true;
        }
    }
}
