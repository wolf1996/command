using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using Terminal;

namespace SpecExplorer.Sample
{
    public class COMPort
    {
        private static Terminal.COMPort com = new Terminal.COMPort();
        public delegate void ComReciever(string msg);
        public event ComReciever onRecieve;

        //--- Конструкторы --------------------------------------------------------------------------------------------
        public static void create(string port_name)
        {
            //com = new Terminal.COMPort(port_name, 115200);
        }

        //--- Открыть COM-порт ----------------------------------------------------------------------------------------
        public static void open(string port_name)
        {
            //com.open();
        }

        //--- Закрыть COM-порт ----------------------------------------------------------------------------------------
        public static void close(string port_name)
        {
            //com.close();
        }

        //--- Отправить строку по COM-порту ---------------------------------------------------------------------------
        public static void send(string str)
        {
            //com.send(str);
        }

        //--- Прием данных по COM-порту -------------------------------------------------------------------------------
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            onRecieve(indata);
        }

        public bool get_state()
        {
            return com.state;
        }
    }
}
