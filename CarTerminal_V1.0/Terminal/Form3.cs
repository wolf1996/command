using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void test_msg(string msg, double time_expectation, int current_mode_number)
        {
            rtb_test_received.Text += msg;
            rtb_test_send.Text += CommandTest.AnswerToCmd(msg, time_expectation, current_mode_number);
        }
    }
}
