using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Terminal;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace SpecFlow
{
    [Binding]
    public class ПовторноеОткрытиеПортаSteps
    {
        private static COMPort com;
        private bool is_error = false;

        [Given(@"порт ""(.*)"" с частотой (.*) открыть")]
        public void ДопустимПортСЧастотойОткрыть(string port_name, int port_rate)
        {
            com = new COMPort(port_name, port_rate);
            com.open();
            Assert.AreEqual(true, com.state);
        }
        
        [When(@"я нажимаю кнопку Открыть")]
        public void ЕслиЯНажимаюКнопкуОткрыть()
        {
            try
            {
                com.open();
            }
            catch(ApplicationException ex)
            {
               
            }
            finally
            {
                is_error = true;
            }
        }
        
        [Then(@"ошибка, порт закрыть")]
        public void ТоОшибкаПортЗакрыть()
        {
            Assert.AreEqual(true, is_error);
            com.close();
        }
    }
}