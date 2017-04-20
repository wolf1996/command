﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal  
{
    /// <summary>
    /// учитывается время с последней команды
    /// ответы на все простые команды
    /// 
    /// </summary>
    public static class CommandTest
    {
        static private Random rand = new Random(DateTime.Now.Millisecond);
        static private int last_cmd_time = DateTime.Now.Millisecond;
        static private int current_mode_number = 0;

        static public int Current_mode_number
        {
            get { return current_mode_number;  }
        }
        /// <returns>ответ на сообщение</returns>
        public static string AnswerToCmd(string msg)
        {
            int new_cmd_time = DateTime.Now.Millisecond;
            int time_diff = new_cmd_time - last_cmd_time;
            last_cmd_time = new_cmd_time;

            string[] cmd = msg.Split(':');
            string answer = "";

            switch (cmd[0])
            {
                case "@MAN_ON":
                    current_mode_number = 0;
                    answer = "@MAN_ON_APPLY";
                    break;
                case "@MAN_OFF":
                    answer = "@MAN_OFF_APPLY";
                    break;
                case "@SEMI_AUTO_ON":
                    current_mode_number = 1;
                    answer = "@SEMI_AUTO_ON_APPLY";
                    break;
                case "@SEMI_AUTO_OFF":
                    answer = "@SEMI_AUTO_OFF_APPLY";
                    break;
                case "@AUTO_ON":
                    current_mode_number = 2;
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
                case "@START": // ответ показания IMU7/ENC3 в автоматическом режиме
                    answer = "@START_APPLY";
                    break;
                case "@STOP":
                    answer = "@STOP_APPLY";
                    break;
                case "@MOTION2": // @MOTION2:speed;rotation
                    if (time_diff > 300)
                    {
                        answer = "@STOP";
                    }
                    else
                    {
                        answer = "";
                    }
                    break;
                case "@SEMI2": // @SEMI2:speed;rotation
                    if (time_diff > 300)
                    {
                        answer = "@STOP";
                    }
                    else
                    {
                        answer = "";
                    }
                    break;
                case "@SEMI3": // @SEMI2:mid_speed;a;freq
                    if (time_diff > 300)
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
    }
}
