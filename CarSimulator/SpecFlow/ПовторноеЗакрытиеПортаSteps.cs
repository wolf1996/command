using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Terminal;

namespace SpecFlow
{
    [Binding]
    public class ПовторноеЗакрытиеПортаSteps
    {
        private static COMPort com;
        private bool is_error = false;

        [Given(@"порт ""(.*)"" с частотой (.*) закрыт")]
        public void ДопустимПортСЧастотойЗакрыт(string port_name, int port_rate)
        {
            com = new COMPort();
            Assert.AreEqual(false, com.state);
        }
        
        [When(@"я нажимаю кнопку Закрыть повторно")]
        public void ЕслиЯНажимаюКнопкуЗакрытьПовторно()
        {
            try
            {
                com.close();
            }
            catch (ApplicationException ex)
            {
                
            }
            finally
            {
                is_error = true;
            }
        }
        
        [Then(@"ошибка, порт уже закрыт")]
        public void ТоОшибкаПортУжеЗакрыт()
        {
            Assert.AreEqual(true, is_error, "Порт был открыт");
        }
    }
}
