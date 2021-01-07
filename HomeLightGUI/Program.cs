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
            UART.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyForm());
        }
    }

    public class Globals    //глобальные переменные (в ООП так не принято вроде)
    {
        public static UInt16 counter1 = 0;
        public static UInt16 counter2 = 0;
        public static bool firstTime = true;
        public static bool blink = true;
    }

    public static class UART    //работа с COM-портом
    {
        private static SerialPort port = new SerialPort();      //объект: port
        private static byte[] bufferTX = new byte[9];           //буфер передачи
        private static int[] bufferRX = new int[9];             //буфер приема
        private static int[] preBufferRX = new int[9];          //буфер до подсчета CRC
        public static void Initialize()     //инициализация протоколов передачи данных, открытие UART 
        {
            port.PortName = "COM7";
            port.BaudRate = 57600;
            port.DataBits = 8;
            port.Parity = System.IO.Ports.Parity.None;
            port.StopBits = System.IO.Ports.StopBits.One;
            port.ReadTimeout = 10;
            port.WriteTimeout = 10;
            port.Open();
            UART.ClearBufferTX();
        }
        public static int RecieveMessage()  //записывает в буфер приема 8 принятых по UART байт
        {
            int summ = 0;
            if (port.BytesToRead > 0)
            {
                try
                {
                    for (int i = 0; i < 8; i++)
                    {
                        preBufferRX[i] = port.ReadByte();
                        if (i < 7) summ += preBufferRX[i];
                    }
                }
                catch (System.TimeoutException)
                {
                    //return;
                }
                if ((summ&255) == preBufferRX[7]) for (int i = 0; i < 8; i++) bufferRX[i] = preBufferRX[i];
            }
            return port.BytesToRead;
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
            UART.port.Write(bufferTX, 0, 8);
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
