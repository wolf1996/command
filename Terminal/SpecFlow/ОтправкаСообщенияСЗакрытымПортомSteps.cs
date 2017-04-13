using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Terminal;

namespace SpecFlow
{
    [Binding]
    public class ОтправкаСообщенияСЗакрытымПортомSteps
    {
        private static COMPort com;
        private string msg;

        [Given(@"я хочу отправить сообщение ""(.*)""")]
        public void ДопустимЯХочуОтправитьСообщение(string msg)
        {
            com = new COMPort("COM28", 115200);
            this.msg = msg;
        }
        
        [When(@"я нажимаю на кнопку Отправить")]
        public void ЕслиЯНажимаюНаКнопкуОтправить()
        {
            com.send(msg);
        }
        
        [Then(@"ошибка, порт закрыт")]
        public void ТоОшибкаПортЗакрыт()
        {
            Assert.AreEqual(false, com.state, "Port is opened");
        }
    }
}
