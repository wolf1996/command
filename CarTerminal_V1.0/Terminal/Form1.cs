using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Runtime.InteropServices;

namespace Terminal
{
    public partial class main_form : Form
    {
        public delegate void KeyStateChange(Keys key, bool state);
        public event KeyStateChange onKeyStateChange;
        public delegate void SpeedChange(int speed);
        public event SpeedChange onSpeedChange;

        private COMPort com = new COMPort();
        private CommandSender command_sender;
        private string path_root;
        private string path_file;

        //--- Конструктор по-умолчанию --------------------------------------------------------------------------------
        public main_form()
        {
            InitializeComponent();
            command_sender = new CommandSender(this);
            onKeyStateChange += command_sender.onKeyStateChange;
            onSpeedChange += command_sender.onSpeedChange;
            foreach(string port in SerialPort.GetPortNames())           // Заполнение списков COM-портов
                cb_port.Items.Add(port);

            cb_port.SelectedIndex = 1;
            cb_baudrate.SelectedIndex = 5;

            path_root = Path.GetFullPath(@"Terminal.exe").Remove(24);
            path_file = path_root + @"Test files\test_ok.txt";
            lbl_path.Text = path_file;

            of_dialog.InitialDirectory = path_root + @"Test files\";

            tab_mode.Enabled = false;
        }

        //--- Действие при закрытии формы -----------------------------------------------------------------------------
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            com.close();
        }

        //--- Нажатие кнопки открытия/закрытия COM-порта --------------------------------------------------------------
        private void btn_open_close_Click(object sender, EventArgs e)
        {
            if (!com.state)                                             // Открыть COM-порт
            {
                string port_name = cb_port.Text;
                int port_rate = Convert.ToInt32(cb_baudrate.Text);
                com = new COMPort(port_name, port_rate);
                com.onRecieve += recieve_msg;
                if (com.open())
                    btn_open_close.Text = "Закрыть";
                tab_mode.Enabled = true;
                tab_mode.SelectedIndex = 0;
                com_send(@"@MAN_ON");
            }
            else                                                        // Закрыть COM-порт
            {
                if (!com.close())
                    btn_open_close.Text = "Открыть";
                tab_mode.Enabled = false;
            }
        }

        //--- Нажатие кнопки "Отправить" ------------------------------------------------------------------------------
        private void btn_send_Click(object sender, EventArgs e)
        {
            com_send(tb_send_command.Text);
        }

        //--- Прием сообщений -----------------------------------------------------------------------------------------
        private void recieve_msg(string msg)
        {
            rtb_recieved.Invoke((MethodInvoker)(delegate() 
            { 
                rtb_recieved.Text += msg + Environment.NewLine;
                rtb_recieved.SelectionStart = rtb_recieved.Text.Length;
                rtb_recieved.ScrollToCaret();
            }));
        }

        //--- Выбор файла для отправки --------------------------------------------------------------------------------
        private void btn_open_file_Click(object sender, EventArgs e)
        {
            if(of_dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path_file = of_dialog.FileName;
                lbl_path.Text = path_file;
            }

        }

        //--- Отправка файла ------------------------------------------------------------------------------------------
        private void btn_send_file_Click(object sender, EventArgs e)
        {
            StreamReader streamReader;
            bool txt = true; 

            try
            {
                streamReader = new StreamReader(path_file);
                while (!streamReader.EndOfStream && txt)
                {
                    string str = streamReader.ReadLine();
                    for (int i = 1; i < str.Length; i += 2)
                    {
                        if ((str[i] == '\0') && (str[i - 1] == '\0'))
                        {
                            txt = false;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения файла: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }

            if (!txt)
                MessageBox.Show("Ошибка чтения файла: файл не является текстовым.", "Error!",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(!com.state)
                MessageBox.Show("Ошибка открытия порта: COM-порт закрыт!", "Error!",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                streamReader.BaseStream.Position = 0;
                while (!streamReader.EndOfStream)
                    com_send(streamReader.ReadLine());
            }               
        }

        //--- Отправка команды по COM-порту ---------------------------------------------------------------------------
        public void com_send(string text)
        {
            rtb_send.Text += com.send(text) + Environment.NewLine;
            rtb_send.SelectionStart = rtb_send.Text.Length;
            rtb_send.ScrollToCaret();
        }

        //--- Выбор режима управления устройством ---------------------------------------------------------------------
        private void tab_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tab_mode.SelectedIndex)
            {
                case 0:
                    com_send(@"@MAN_ON");
                    break;
                case 1:
                    com_send(@"@SEMI_ON");
                    break;
                case 2:
                    com_send(@"@AUTO_ON");
                    break;
                default:
                    com_send(@"@NOT_DETECTED");
                    break;
            }
        }

        //--- Регулировка скорости в ручном режиме --------------------------------------------------------------------
        private void trb_man_speed_ValueChanged(object sender, EventArgs e)
        {
            nud_man_speed.Value = trb_man_speed.Value;
            onSpeedChange(trb_man_speed.Value);
        }
        private void nud_man_speed_ValueChanged(object sender, EventArgs e)
        {
            trb_man_speed.Value = Convert.ToInt32(nud_man_speed.Value);
            onSpeedChange(trb_man_speed.Value);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern short GetKeyState(int keyCode);
        private void tab_mode_KeyDown(object sender, KeyEventArgs e)
        {  
            switch (e.KeyCode)
            {
                case Keys.W:
                    lbl_forward.BackColor = Color.Yellow;
                    break;
                case Keys.S:
                    lbl_back.BackColor = Color.Yellow;
                    break;
                case Keys.A:
                    lbl_left.BackColor = Color.Yellow;
                    break;
                case Keys.D:
                    lbl_right.BackColor = Color.Yellow;
                    break;
                case Keys.L:
                    if (lbl_led.BackColor == Color.Yellow) lbl_led.BackColor = Color.Transparent;
                    else lbl_led.BackColor = Color.Yellow;
                    break;
            }
            onKeyStateChange(e.KeyCode, true);
        }

        private void tab_mode_KeyUp(object sender, KeyEventArgs e)
        {
            lbl_forward.BackColor = Color.Transparent;
            lbl_back.BackColor = Color.Transparent;
            lbl_left.BackColor = Color.Transparent;
            lbl_right.BackColor = Color.Transparent;
            onKeyStateChange(e.KeyCode, false);
        }


    }

}
