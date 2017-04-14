﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Terminal
{
    public class KeyState
    {
        public Keys key;
        public bool state = false;
 
        public KeyState(Keys key)
        {
            this.key = key;
        }
    }
    public class CommandSender
    {
        private int speed = 0;
        private KeyState []keys = new KeyState[5];
        public delegate void NewMessage(string text);
        public event NewMessage onNewMessage;
        Form form_parent;

        public CommandSender(main_form parent)
        {
            this.form_parent = parent;
            onNewMessage += parent.com_send;
            keys[0] = new KeyState(Keys.W);
            keys[1] = new KeyState(Keys.S);
            keys[2] = new KeyState(Keys.A);
            keys[3] = new KeyState(Keys.D);
            keys[4] = new KeyState(Keys.L);
        }

        public void key_state(Keys key, bool state)
        {
            if ((key == keys[4].key) && state)
            {
                keys[4].state = !keys[4].state;
                send_led_command();
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    if (keys[i].key == key)
                        keys[i].state = state;
                }
                send_move_command();
            }       
        }

        public void speed_change(int speed)
        {
            this.speed = speed;
        }

        private void send_move_command()
        {
            int s = 0;
            int r = 0;
            if(keys[0].state) s = 1;
            if(keys[1].state) s = -1;
            if(keys[2].state) r = 1;
            if(keys[3].state) r = -1;
            s *= speed;
            onNewMessage(@"@MOTION2:" + s.ToString() + ";" + r.ToString());
        }

        private void send_led_command()
        {
            if (keys[4].state) onNewMessage(@"@LED_ON");
            else onNewMessage(@"@LED_OFF");
        }
    }
}
