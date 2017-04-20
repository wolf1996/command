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

using System.Threading;

namespace Terminal
{
    public partial class Form1 : Form
    {
        private COMPort com = new COMPort();
        private string path_root;
        private string path_file;
        private bool thread_flag = false;

        static private Thread sender_thread;

        //--- Конструктор по-умолчанию --------------------------------------------------------------------------------
        public Form1()
        {
            InitializeComponent();
            foreach(string port in SerialPort.GetPortNames())           // Заполнение списков COM-портов
                cb_port.Items.Add(port);

            cb_port.SelectedIndex = 1;
            cb_baudrate.SelectedIndex = 5;

            path_root = Path.GetFullPath(@"Terminal.exe").Remove(24);
            path_file = path_root + @"Test files\test_ok.txt";
            lbl_path.Text = path_file;

            of_dialog.InitialDirectory = path_root + @"Test files\";
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

                com.onRecieve += test_msg; // подписал автоответчик на событие приема
 
                if (com.open())
                    btn_open_close.Text = "Закрыть";
            }
            else                                                        // Закрыть COM-порт
            {
                if (!com.close())
                    btn_open_close.Text = "Открыть";
            }
        }

        //--- Нажатие кнопки "Отправить" ------------------------------------------------------------------------------
        private void btn_send_Click(object sender, EventArgs e)
        {
            com_send(tb_send_command.Text);  // отправлю ответ на полученную команду
        }

        //--- Автоответчик --------------------------------------------------------------------------------------------
        private void test_msg(string msg) 
        {
            string answer = CommandTest.AnswerToCmd(msg);   // генерирую ответ
            if ((CommandTest.Current_mode_number != 0) && answer.Equals("@START_APPLY"))
            {
                if (!thread_flag) (sender_thread = new Thread(new ThreadStart(AutoGenCmd))).Start();
                thread_flag = true;
            }
            else
            {
                if (sender_thread != null)
                {
                    if (sender_thread.IsAlive)
                    {
                        sender_thread.Abort();
                        thread_flag = false;
                    }
                }        
            }
            com_send(answer);  // Отправлю ответ на полученную команду
        }

        //--- Генерация показаний датчиков ----------------------------------------------------------------------------
        private void AutoGenCmd()
        {
            double last_time = 0;
            Random rand = new Random(DateTime.Now.Millisecond);
            string cmd = "";
            int cnt = 0;
            while (true)
            {
                int pause_period = rand.Next(500, 1200);        // Генерируем значение time
                Thread.Sleep(pause_period);
                last_time += pause_period;

                if ((cnt % 2) == 0)
                {
                    cmd = "@IMU7:" + last_time;
                    for (int i = 0; i < 6; i++)
                    {
                        cmd += ";" + String.Format("{0:0.000}", rand.NextDouble());
                    }
                }
                else
                {
                    cmd = "@ENC3:" + last_time;
                    for (int i = 0; i < 2; i++)
                    {
                        cmd += ";" + Convert.ToInt32(rand.NextDouble()*100.0);
                    }
                }

                com_send(cmd);
                cnt++;
            }
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
            rtb_recieved.Invoke((MethodInvoker)(delegate()
            {
                rtb_send.Text += com.send(text) + Environment.NewLine;
                rtb_send.SelectionStart = rtb_send.Text.Length;
                rtb_send.ScrollToCaret();
            }));
        }
    }

}
