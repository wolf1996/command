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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void imu7_handler(String[] elems)
        {
            Double time = Convert.ToDouble(elems[1]);
            Double x = Convert.ToDouble(elems[2]);
            Double y = Convert.ToDouble(elems[3]);
            Double z = Convert.ToDouble(elems[4]);
            gyroX.Series[0].Points.AddXY(time, x);
            gyroY.Series[0].Points.AddXY(time, y);
            gyroZ.Series[0].Points.AddXY(time, z);
        }

        private void enc3_handler(String[] elems)
        {
            Double time = Convert.ToDouble(elems[1]);
            Double l = Convert.ToDouble(elems[2]);
            Double r = Convert.ToDouble(elems[3]);
            enc3L.Series[0].Points.AddXY(time, l);
            enc3R.Series[0].Points.AddXY(time, r);
        }

        public void get_data(String input)
        {
            String[] elems = input.Split(new Char[] { ':', ';' });
            if (String.Compare(elems[0], "IMU7") == 0)
            {
                imu7_handler(elems);
            }
            if (String.Compare(elems[0], "ENC3") == 0)
            {
                enc3_handler(elems);
            }
        }
    }
}
