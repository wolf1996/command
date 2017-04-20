using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal
{
    public static class CommandTest
    {
        static Random rand = new Random(DateTime.Now.Millisecond);
        static double last_time = 0;
        /// <returns>ответ на сообщение</returns>
        public static string AnswerToCmd(string msg, double time_expectation, int current_mode_number) 
        {
            string[] cmd = msg.Split(':');
            string answer = "";

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
                    if (current_mode_number == 0)
                    {
                        answer = "@START_APPLY";
                    }
                    else
                    {
                        answer = AutoGenCmd();
                    }
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
                case "@SEMI3": // @SEMI2:mid_speed;a;freq
                    if (time_expectation > 300)
                    {
                        answer = "@STOP";
                    }
                    else
                    {
                        answer = "@SEMI_APPLY";
                    }
                    break;
                case "@AUTO_INIT6": // @AUTO_INIT6: freq; weight; coe; imp; radius_static; radius_dynamic
                    answer = "@AUTO_INIT_APPLY";
                    break;
                case "IMU7": // IMU7:time;axel_x;axel_y;axel_z;gyro_x;gyro_y;gyro_z
                    answer = "";
                    break;
                case "ENC3": // ENC3:time;enc_l;enc_r
                    answer = "";
                    break;

                default:
                    answer = "unexpected";
                    break;
            }

            return answer;
        }

        private static string AutoGenCmd()
        {
            int n_rand_params;
            string cmd = "";
            if (rand.Next(0, 1) == 0)
            {
                n_rand_params = 6;
                cmd += "@IMU7:";
            }
            else
            {
                n_rand_params = 2;
                cmd += "ENC3:";
            }
            last_time += rand.NextDouble();
            cmd += last_time;
            for (int i = 0; i < n_rand_params; i++)
            {
                cmd += ";" + rand.NextDouble();
            }
            return cmd;
        }
    }
}
