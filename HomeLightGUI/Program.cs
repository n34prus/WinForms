using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;

namespace HomeLightGUI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SelectPortForm());
            //MessageBox.Show("CONNECTED TO PORT!");
            //while (!Globals.portIsOpen) if (UART.Initialize()) Globals.portIsOpen = true;
            Application.Run(new GeneralForm());
        }
    }

    public class Globals    //глобальные переменные (в ООП так не принято вроде)
    {
        public static bool flagUpdateAlarm = true;
        public static bool flagFirstStart = true;
        public static bool blink = true;
        public static byte counter_tabTIME = 0;
        public static bool portIsOpen = false;
    }

    public static class UART    //работа с COM-портом
    {
        private static SerialPort _port = new SerialPort();      //объект: port
        private static byte[] bufferTX = new byte[9];           //буфер передачи
        private static int[] bufferRX = new int[9];             //буфер приема
        private static int[] preBufferRX = new int[9];          //буфер до подсчета CRC
        private static string portName = "COM4";

        public static void SetPort(string _portName)
        {
            portName = _portName;
        }
        public static bool Initialize()     //инициализация протоколов передачи данных, открытие UART 
        {

            //_port.PortName = "COM4"; //по умолчанию БТ
            _port.PortName = portName;
            /*
            string[] ports = SerialPort.GetPortNames();
            
            foreach (string enabledPort in ports)   //если подключен провод
            {
                if (enabledPort == "COM7") port.PortName = "COM7";
            }
            */
            _port.BaudRate = 57600;
            _port.DataBits = 8;
            _port.Parity = System.IO.Ports.Parity.None;
            _port.StopBits = System.IO.Ports.StopBits.One;
            _port.ReadTimeout = 5000;
            _port.WriteTimeout = 5000;
            //_port.Close();
            //Thread.Sleep(1000);
            try
            {
                for (int i=0; i<=0; i++)
                //while()
                {
                    if (!_port.IsOpen)
                    {
                        _port.Open();
                        //Thread.Sleep(10);
                    }
                }
            }
            catch (Exception e )
            {
                Console.WriteLine("cant open port " + _port.PortName);
                return false;
            }
            UART.ClearBufferTX();
            return true;
        }
        public static int RecieveMessage()  //записывает в буфер приема 8 принятых по UART байт
        {
            int summ = 0;
            if (_port.IsOpen)
            {
                if (_port.BytesToRead > 0)
                {
                    try
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            preBufferRX[i] = _port.ReadByte();
                            if (i < 7) summ += preBufferRX[i];
                        }
                    }
                    catch (System.TimeoutException)
                    {
                        return 0;
                    }
                    if ((summ & 255) == preBufferRX[7]) for (int i = 0; i < 8; i++) bufferRX[i] = preBufferRX[i];
                }
                return _port.BytesToRead;
            }
            else return 0;
            
        }
        public static int GetByteFromBufferRX(int index)    //возвращает принятый байт по индексу
        {
            return bufferRX[index];
        }

        public static void ClearBufferTX()  //очищает буфер передачи
        {
            for (int i = 0; i < 8; i++)
                UART.bufferTX[i] = (byte)0;
        }
        public static void WriteByteToBufferTX(int value, int index)   //записывает в буфер передачи байт по его индексу
        {
            if ((index >= 0) && (index < 8))  UART.bufferTX[index] = (byte)value;
        }
        public static int SendBufferTX()   //формирует CRC и отправляет 8 байт буфера передачи в UART, возвращает CRC
        {
            int summ = 0;
            for (int i = 0; i< 7; i++)
            {
                summ += UART.bufferTX[i];
            }
            UART.WriteByteToBufferTX((byte)(summ), 7);
            UART._port.Write(bufferTX, 0, 8);
            UART.ClearBufferTX();
            return summ;
        }
    }
    public static class TIME    //работа с временем и будильником
    {
        public static byte[] bufferSysTime = new byte[8];          //буфер s-m-h d-m-y-wd
        public static string[] daysOfWeek = { "ВС", "ПН","ВТ","СР","ЧТ","ПТ","СБ" };          //буфер s-m-h d-m-y-wd
        public static void updateSysTimeBuffer()
        {
            bufferSysTime[0] = (byte)DateTime.Now.Second;
            bufferSysTime[1] = (byte)DateTime.Now.Minute;
            bufferSysTime[2] = (byte)DateTime.Now.Hour;
            bufferSysTime[3] = (byte)DateTime.Now.Day;
            bufferSysTime[4] = (byte)DateTime.Now.Month;
            bufferSysTime[5] = (byte)(DateTime.Now.Year - 2000);
            bufferSysTime[6] = (byte)DateTime.Now.DayOfWeek;
        }

    }
}
