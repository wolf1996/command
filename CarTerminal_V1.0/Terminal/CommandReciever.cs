using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal
{
    public class CommandAnswer
    {
        public string command = "";
        public string answer = "";

        public CommandAnswer(string command, string answer)
        {
            this.answer = answer;
            this.command = command;
        }
    }
    /// <summary>
    /// Учитывается время с последней команды
    /// Ответы на все простые команды
    /// 
    /// </summary>
    public static class CommandReciever
    {
        public static bool isCorrect(string message, string command)
        {
            CommandAnswer[] commands_answers = { new CommandAnswer("@MAN_ON", "@MAN_ON_APPLY"), 
                                                 new CommandAnswer("@MAN_OFF", "@MAN_OFF_APPLY"),
                                                 new CommandAnswer("@SEMI_AUTO_ON", "@SEMI_AUTO_ON_APPLY"),
                                                 new CommandAnswer("@SEMI_AUTO_OFF", "@SEMI_AUTO_OFF_APPLY"),
                                                 new CommandAnswer("@AUTO_ON", "@AUTO_ON_APPLY"),
                                                 new CommandAnswer("@AUTO_OFF", "@AUTO_OFF_APPLY"), 
                                                 new CommandAnswer("@START", "@START_APPLY"),
                                                 new CommandAnswer("@STOP", "@STOP_APPLY"),
                                                 new CommandAnswer("@AUTO_INIT6", "@AUTO_INIT_APPLY"),
                                                 new CommandAnswer("@MAN_ON", "@MAN_ON_APPLY"),
                                                 new CommandAnswer("@MAN_ON", "@MAN_ON_APPLY"),
                                                 new CommandAnswer("@START", "@IMU7"),
                                                 new CommandAnswer("@START", "@ENC3")}; 

            string[] msg = message.Split(':');

            foreach (CommandAnswer ca in commands_answers)
            {
                if(ca.command == command)           // Команда есть в словаре
                {
                    if (ca.answer == msg[0])        // Ответ совпал
                        return true;
                    else
                        return false;
                }
            }

            return true;
        }
    }
}
