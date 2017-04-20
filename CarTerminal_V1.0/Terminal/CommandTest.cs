using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal
{
    public class CommandTest
    {
        public string ReceiveCmd(string msg)
        {
            string[] cmd = msg.Split(':');
            string[] parameters;
            string answer;

            switch (cmd[0])
            {
                case "@MAN_ON":
                    answer = "@MAN_ON_APPLY";
                    break;
                case "@MAN_OFF":
                    answer = "@MAN_OFF_APPLY";
                    break;
                case "@SEMI_AUTO_ON":
                    answer = "@SEMI_AUTO_ON_APPLY";
                    break;
                case "@SEMI_AUTO_OFF":
                    answer = "@SEMI_AUTO_OFF_APPLY";
                    break;
                case "@AUTO_ON":
                    answer = "@AUTO_ON_APPLY";
                    break;
                case "@AUTO_OFF":
                    answer = "@AUTO_OFF_APPLY";
                    break;
                case "@LED_ON": 
                    answer = "";
                    break;
                case "@LED_OFF": 
                    answer = "";
                    break;
                case "@START": // ответ IMU7/ENC3 в автоматическом режиме
                    answer = "@START_APPLY";
                    break;
                case "@STOP":
                    answer = "@STOP_APPLY";
                    break;
                case "@MOTION2": // @MOTION2:speed;rotation
                    if (time_expectation > 300)
                    {
                        answer = "@STOP";
                    }
                    else
                    {
                        answer = "";
                    }
                    break;
                case "@SEMI2": // @SEMI2:speed;rotation
                    if (time_expectation > 300)
                    {
                        answer = "@STOP";
                    }
                    else
                    {
                        answer = "";
                    }
                    break;
                case "@AUTO_INIT6": // @AUTO_INIT6: freq; weight; coe; imp; radius_static; radius_dynamic
                    answer = "@AUTO_INIT_APPLY";
                    break;
                case "IMU7": // IMU7:time;axel_x;axel_y;axel_z;gyro_x;gyro_y;gyro_z
                    // parameters = msg.Split(';');
                    // ответ всегда пустой?
                    answer = "";
                    break;
                case "ENC3": // ENC3:time;enc_l;enc_r
                    // ответ всегда пустой?
                    answer = "";
                    break;

                default:
                    answer = "unexpected";
                    break;
            }

            return answer;
        }
    }
}
