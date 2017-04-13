using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Terminal;

namespace SpecFlow
{
    [Binding]
    public class ЗакрытиеПортаSteps
    {
        private static COMPort com;
        [Given(@"порт ""(.*)"" с частотой (.*) открыт")]
        public void ДопустимПортСЧастотойОткрыт(string port_name, int port_rate)
        {
            com = new COMPort(port_name, port_rate);
            com.open();
            Assert.AreEqual(true, com.state);
        }
        
        [When(@"я нажимаю кнопку Закрыть")]
        public void ЕслиЯНажимаюКнопкуЗакрыть()
        {
            com.close();
        }
        
        [Then(@"Порт закрывается")]
        public void ТоПортЗакрывается()
        {
            Assert.AreEqual(false, com.state);
        }
    }
}
