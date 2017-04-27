using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Terminal
{
    public partial class Form2 : Form
    {
        private Form parent_form;

        public Form2(Form parent_form)
        {
            this.parent_form = parent_form;

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void imu7_handler(String[] elems)
        {
            Double time = Convert.ToDouble(elems[1]);
            Double x_a = Convert.ToDouble(elems[2]);
            Double y_a = Convert.ToDouble(elems[3]);
            Double z_a = Convert.ToDouble(elems[4]);
            Double x_g = Convert.ToDouble(elems[5]);
            Double y_g = Convert.ToDouble(elems[6]);
            Double z_g = Convert.ToDouble(elems[7]);
            axelX.Series[0].Points.AddXY(time, x_a);
            axelY.Series[0].Points.AddXY(time, y_a);
            axelZ.Series[0].Points.AddXY(time, z_a);
            gyroX.Series[0].Points.AddXY(time, x_g);
            gyroY.Series[0].Points.AddXY(time, y_g);
            gyroZ.Series[0].Points.AddXY(time, z_g);
        }

        private void enc3_handler(String[] elems)
        {
            Double time = Convert.ToDouble(elems[1]);
            Double l = Convert.ToDouble(elems[2]);
            Double r = Convert.ToDouble(elems[3]);
            enc3L.Series[0].Points.AddXY(time, l);
            enc3R.Series[0].Points.AddXY(time, r);
        }

        public void get_data(string input)
        {
            input = input.Replace('.', ',');
            String[] elems = input.Split(new Char[] { ':', ';' });
            if ((String.Compare(elems[0], "@IMU7") == 0))
            {
                imu7_handler(elems);
            }
            if ((String.Compare(elems[0], "@ENC3") == 0))
            {
                enc3_handler(elems);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form mf = parent_form as main_form;
            
        }
    }
}
