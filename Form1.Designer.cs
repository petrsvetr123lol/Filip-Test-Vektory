namespace filip_test
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbox_main = new System.Windows.Forms.PictureBox();
            this.pbox_c1 = new System.Windows.Forms.PictureBox();
            this.pbox_c2 = new System.Windows.Forms.PictureBox();
            this.pbox_c3 = new System.Windows.Forms.PictureBox();
            this.pbox_c4 = new System.Windows.Forms.PictureBox();
            this.pbox_c5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numeric_size = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.check_random = new System.Windows.Forms.CheckBox();
            this.numeric_x = new System.Windows.Forms.NumericUpDown();
            this.numeric_y = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.button_generate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_c5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_size)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_y)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.numeric_size);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbox_c5);
            this.panel1.Controls.Add(this.pbox_c4);
            this.panel1.Controls.Add(this.pbox_c3);
            this.panel1.Controls.Add(this.pbox_c2);
            this.panel1.Controls.Add(this.pbox_c1);
            this.panel1.Location = new System.Drawing.Point(-7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 79);
            this.panel1.TabIndex = 0;
            // 
            // pbox_main
            // 
            this.pbox_main.BackColor = System.Drawing.Color.White;
            this.pbox_main.Location = new System.Drawing.Point(1, 108);
            this.pbox_main.Name = "pbox_main";
            this.pbox_main.Size = new System.Drawing.Size(801, 391);
            this.pbox_main.TabIndex = 1;
            this.pbox_main.TabStop = false;
            this.pbox_main.Click += new System.EventHandler(this.pbox_main_Click);
            this.pbox_main.Paint += new System.Windows.Forms.PaintEventHandler(this.pbox_main_Paint);
            // 
            // pbox_c1
            // 
            this.pbox_c1.BackColor = System.Drawing.Color.White;
            this.pbox_c1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox_c1.Location = new System.Drawing.Point(21, 21);
            this.pbox_c1.Name = "pbox_c1";
            this.pbox_c1.Size = new System.Drawing.Size(43, 40);
            this.pbox_c1.TabIndex = 2;
            this.pbox_c1.TabStop = false;
            this.pbox_c1.Click += new System.EventHandler(this.pbox_c1_Click);
            // 
            // pbox_c2
            // 
            this.pbox_c2.BackColor = System.Drawing.Color.White;
            this.pbox_c2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox_c2.Location = new System.Drawing.Point(83, 21);
            this.pbox_c2.Name = "pbox_c2";
            this.pbox_c2.Size = new System.Drawing.Size(43, 40);
            this.pbox_c2.TabIndex = 3;
            this.pbox_c2.TabStop = false;
            this.pbox_c2.Click += new System.EventHandler(this.pbox_c2_Click);
            // 
            // pbox_c3
            // 
            this.pbox_c3.BackColor = System.Drawing.Color.White;
            this.pbox_c3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox_c3.Location = new System.Drawing.Point(147, 21);
            this.pbox_c3.Name = "pbox_c3";
            this.pbox_c3.Size = new System.Drawing.Size(43, 40);
            this.pbox_c3.TabIndex = 4;
            this.pbox_c3.TabStop = false;
            this.pbox_c3.Click += new System.EventHandler(this.pbox_c3_Click);
            // 
            // pbox_c4
            // 
            this.pbox_c4.BackColor = System.Drawing.Color.White;
            this.pbox_c4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox_c4.Location = new System.Drawing.Point(210, 21);
            this.pbox_c4.Name = "pbox_c4";
            this.pbox_c4.Size = new System.Drawing.Size(43, 40);
            this.pbox_c4.TabIndex = 5;
            this.pbox_c4.TabStop = false;
            this.pbox_c4.Click += new System.EventHandler(this.pbox_c4_Click);
            // 
            // pbox_c5
            // 
            this.pbox_c5.BackColor = System.Drawing.Color.White;
            this.pbox_c5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox_c5.Location = new System.Drawing.Point(276, 21);
            this.pbox_c5.Name = "pbox_c5";
            this.pbox_c5.Size = new System.Drawing.Size(43, 40);
            this.pbox_c5.TabIndex = 3;
            this.pbox_c5.TabStop = false;
            this.pbox_c5.Click += new System.EventHandler(this.pbox_c5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kruh 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(88, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kruh 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(152, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kruh 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(215, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kruh 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(281, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kruh 5";
            // 
            // numeric_size
            // 
            this.numeric_size.Location = new System.Drawing.Point(665, 30);
            this.numeric_size.Name = "numeric_size";
            this.numeric_size.Size = new System.Drawing.Size(120, 20);
            this.numeric_size.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(615, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Velikost";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button_generate);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.numeric_y);
            this.panel2.Controls.Add(this.numeric_x);
            this.panel2.Controls.Add(this.check_random);
            this.panel2.Location = new System.Drawing.Point(-7, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 35);
            this.panel2.TabIndex = 2;
            // 
            // check_random
            // 
            this.check_random.AutoSize = true;
            this.check_random.Location = new System.Drawing.Point(23, 11);
            this.check_random.Name = "check_random";
            this.check_random.Size = new System.Drawing.Size(70, 17);
            this.check_random.TabIndex = 0;
            this.check_random.Text = "Náhodně";
            this.check_random.UseVisualStyleBackColor = true;
            this.check_random.CheckedChanged += new System.EventHandler(this.check_random_CheckedChanged);
            // 
            // numeric_x
            // 
            this.numeric_x.Location = new System.Drawing.Point(667, 8);
            this.numeric_x.Name = "numeric_x";
            this.numeric_x.Size = new System.Drawing.Size(120, 20);
            this.numeric_x.TabIndex = 1;
            // 
            // numeric_y
            // 
            this.numeric_y.Location = new System.Drawing.Point(511, 8);
            this.numeric_y.Name = "numeric_y";
            this.numeric_y.Size = new System.Drawing.Size(120, 20);
            this.numeric_y.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(491, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(647, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "X";
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(99, 5);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(75, 23);
            this.button_generate.TabIndex = 13;
            this.button_generate.Text = "Generuj";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pbox_main);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Olympiáda - Petr Filip";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_c5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_size)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_y)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbox_main;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbox_c5;
        private System.Windows.Forms.PictureBox pbox_c4;
        private System.Windows.Forms.PictureBox pbox_c3;
        private System.Windows.Forms.PictureBox pbox_c2;
        private System.Windows.Forms.PictureBox pbox_c1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numeric_size;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numeric_y;
        private System.Windows.Forms.NumericUpDown numeric_x;
        private System.Windows.Forms.CheckBox check_random;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Button button_generate;
    }
}

