using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filip_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pbox_c1_Click(object sender, EventArgs e)
        {
            colorPicker.ShowDialog();
            pbox_c1.BackColor = colorPicker.Color;
        }

        private void pbox_c2_Click(object sender, EventArgs e)
        {
            colorPicker.ShowDialog();
            pbox_c2.BackColor = colorPicker.Color;
        }

        private void pbox_c3_Click(object sender, EventArgs e)
        {
            colorPicker.ShowDialog();
            pbox_c3.BackColor = colorPicker.Color;
        }

        private void pbox_c4_Click(object sender, EventArgs e)
        {
            colorPicker.ShowDialog();
            pbox_c4.BackColor = colorPicker.Color;
        }

        private void pbox_c5_Click(object sender, EventArgs e)
        {
            colorPicker.ShowDialog();
            pbox_c5.BackColor = colorPicker.Color;
        }

        private void check_random_CheckedChanged(object sender, EventArgs e)
        {
            if (check_random.Checked == true)
            {
                numeric_y.Enabled = false;
                numeric_x.Enabled = false;
            }
            else
            {
                numeric_y.Enabled = true;
                numeric_x.Enabled = true;
            }
        }
    }
}
