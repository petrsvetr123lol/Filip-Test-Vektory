using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace filip_test
{
    public partial class Form1 : Form
    {
        List<Rings> rings;
        public Form1()
        {
            InitializeComponent();
            numeric_size.Minimum = 150;
            numeric_size.Maximum = 450;
            numeric_x.Maximum = 500;
            numeric_y.Maximum = 500;
            rings = new List<Rings>();
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

        private void pbox_main_Click(object sender, EventArgs e)
        {
           //tohle fungovat nebude, víc se mi líbí tlačítko:))
        }

        private void pbox_main_Paint(object sender, PaintEventArgs e)
        {
            foreach (var ring in rings)
            {
                ring.Draw(e.Graphics);
            }
        }

        private void button_generate_Click(object sender, EventArgs e)
        { 

            if (check_random.Checked == true)
            {
                Random random = new Random();
                Rings ring = new Rings();
                ring.Location = new Point(random.Next(0, pbox_main.Width), random.Next(0, pbox_main.Height));
                ring.Size = Convert.ToInt32(numeric_size.Value);
                ring.Ring1 = pbox_c1.BackColor;
                ring.Ring2 = pbox_c2.BackColor;
                ring.Ring3 = pbox_c3.BackColor;
                ring.Ring4 = pbox_c4.BackColor;
                ring.Ring5 = pbox_c5.BackColor;
                rings.Add(ring);
                pbox_main.Refresh();
            }
            
            if (check_random.Checked == false)
            {
                Rings ring = new Rings();
                ring.Location = new Point((int)numeric_x.Value, (int)numeric_y.Value);
                ring.Size = Convert.ToInt32(numeric_size.Value);
                ring.Ring1 = pbox_c1.BackColor;
                ring.Ring2 = pbox_c2.BackColor;
                ring.Ring3 = pbox_c3.BackColor;
                ring.Ring4 = pbox_c4.BackColor;
                ring.Ring5 = pbox_c5.BackColor;
                rings.Add(ring);
                pbox_main.Refresh();
            }
        }
    }
}
