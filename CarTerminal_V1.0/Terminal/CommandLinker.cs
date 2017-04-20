using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Terminal
{
    //*** Класс состояния кнопок клавиатуры ***************************************************************************
    public class KeyState
    {
        public Keys key;
        public bool state = false;
 
        public KeyState(Keys key)
        {
            this.key = key;
        }
    }

    //*** Класс компановки команд *************************************************************************************
    public class CommandLinker
    {
        private int current_mode_num = 0;
        private int speed = 0;
        private KeyState []keys = new KeyState[5];
        private string []modes = {"@MAN", "@SEMI_AUTO", "@AUTO"};
        public delegate void NewMessage(string text);
        public event NewMessage onNewMessage;
        private Form form_parent;

        //--- Конструктор ---------------------------------------------------------------------------------------------
        public CommandLinker(main_form parent)
        {
            this.form_parent = parent;
            onNewMessage += parent.com_send;
            keys[0] = new KeyState(Keys.W);
            keys[1] = new KeyState(Keys.S);
            keys[2] = new KeyState(Keys.A);
            keys[3] = new KeyState(Keys.D);
            keys[4] = new KeyState(Keys.L);
        }

        //--- Обработчик изменения режима управления ------------------------------------------------------------------
        public void onModeChange(int mode_num)
        {
            //if (current_mode_num != mode_num) onNewMessage(modes[current_mode_num] + @"_OFF");
            send_msg(modes[mode_num] + @"_ON");
            current_mode_num = mode_num;
        }

        //--- Обработчик изменения состояния кнопки -------------------------------------------------------------------
        public void onKeyStateChange(Keys key, bool state)
        {
            if ((key == keys[4].key))                   // Включение\выключние фар
            {
                if(state)
                {
                    keys[4].state = !keys[4].state;
                    send_led_command();
                } 
            }
            else                                        // Движение в ручном режиме
            {
                for (int i = 0; i < 4; i++)
                {
                    if (keys[i].key == key)
                    {
                        keys[i].state = state;
                        send_man_move_command();
                    }
                        
                }
            }       
        }

        //--- Обработчик изменения заданной скорости движения ---------------------------------------------------------
        public void onSpeedChange(int speed)
        {
            this.speed = speed;
        }

        //--- Обработчик изменения параметров полуавтоматического режима ----------------------------------------------
        public void onSemiParametersChange(int mid_speed, int a, int freq)
        {
            send_semi_init_command(mid_speed, a, freq);
        }

        //--- Обработчик изменения параметров автоматического режима --------------------------------------------------
        public void onAutoParametersChange(int weight, int freq, int coe, int imp, int rd, int rs)
        {
            send_auto_init_command(weight, freq, coe, imp, rd, rs);
        }

        //--- Обработчик нажатия кнопки "Старт" -----------------------------------------------------------------------
        public void onStart()
        {
            send_msg(@"@START");
        }

        //--- Обработчик нажатия кнопки "Стоп" ------------------------------------------------------------------------
        public void onStop()
        {
            send_msg(@"@STOP");
        }

        //--- Отправка команды движения в ручном режиме ---------------------------------------------------------------
        private void send_man_move_command()
        {
            int s = 0;
            int r = 0;
            if(keys[0].state) s = 1;
            if(keys[1].state) s = -1;
            if(keys[2].state) r = 1;
            if(keys[3].state) r = -1;
            s *= speed;
            send_msg(@"@MOTION2:" + s.ToString() + ";" + r.ToString());
        }

        //--- Отправка команды включения\выключения фар ---------------------------------------------------------------
        private void send_led_command()
        {
            if (keys[4].state) send_msg(@"@LED_ON");
            else send_msg(@"@LED_OFF");
        }

        //--- Отправка команды инициализации полуавтоматического режима -----------------------------------------------
        private void send_semi_init_command(int mid_speed, int a, int freq)
        {
            send_msg(@"@SEMI3:" + mid_speed.ToString() + ";" + a.ToString() + ";" + freq.ToString());
        }

        //--- Отправка команды инициализации автоматического режима ---------------------------------------------------
        private void send_auto_init_command(int weight, int freq, int coe, int imp, int rd, int rs)
        {
            send_msg(@"@AUTO_INIT6:" + freq.ToString() + ";" + weight.ToString() + ";" + coe.ToString() + ";" + 
                                            imp.ToString() + ";" + rs.ToString() + ";" + rd.ToString());
        }

        //--- Отправка сообщения только в случае, если COM-порт свободен ----------------------------------------------
        private void send_msg(string text)
        {
            while (!(form_parent as main_form).com_state) { }
            onNewMessage(text);
        }
    }
}
