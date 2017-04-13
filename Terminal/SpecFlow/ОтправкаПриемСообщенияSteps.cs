using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Terminal;

namespace SpecFlow
{
    [Binding]
    public class ОтправкаПриемСообщенияSteps
    {
        private static COMPort com1, com2;
        private string msg;
        private static bool is_recieved = false;

        [Given(@"порт ""(.*)"" и порт ""(.*)"" с частотой (.*) открыты")]
        public void ДопустимПортИПортСЧастотойОткрыты(string port_name1, string port_name2, int port_rate)
        {
            com1 = new COMPort(port_name1, port_rate);
            com1.open();

            com2 = new COMPort(port_name2, port_rate);
            com2.open();
            com2.onRecieve += recieve_msg;
            Assert.AreEqual(true, com1.state, "com_1 not open");
            Assert.AreEqual(true, com2.state, "com_2 not open");
        }
        
        [Given(@"я ввел сообщение ""(.*)""")]
        public void ДопустимЯВвелСообщение(string msg)
        {
            this.msg = msg;
        }
        
        [When(@"я нажимаю кнопку Отправить")]
        public void ЕслиЯНажимаюКнопкуОтправить()
        {
            com1.send(msg);
        }

        [Then(@"я жду")]
        public void ЯЖду()
        {
            int i = 0;
            while (!is_recieved && (i < 1000000)) { i++; }
        }

        [Then(@"сообщение отправляется")]
        public void ТоСообщениеОтправляется()
        {
            Assert.AreEqual(true, is_recieved, "Not recieved");
            com1.close();
            com2.close();
        }

        private void recieve_msg(string msg)
        {
            is_recieved = true;
        }
    }
}
