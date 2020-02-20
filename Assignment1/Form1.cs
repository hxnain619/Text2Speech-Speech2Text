using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.label3.MouseHover += BtnHoverEffect;
            this.label4.MouseHover += BtnHoverEffect2;

            this.label3.MouseLeave += BtnHoverOut;
            this.label4.MouseLeave += BtnHoverOut2;

            this.label3.Paint += BorderColorChange2;
            this.label4.Paint += BorderColorChange;

        }
        private void BorderColorChange(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, label3.DisplayRectangle, Color.FromArgb(30, 193, 120), ButtonBorderStyle.Solid);
        }

        private void BorderColorChange2(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, label3.DisplayRectangle, Color.White, ButtonBorderStyle.Solid);
        }
        private void BtnHoverEffect(object sender, EventArgs e)
        {
            this.label3.BackColor = Color.White;
            this.label3.ForeColor = Color.FromArgb(30, 193, 120);

        }
        private void BtnHoverEffect2(object sender, EventArgs e)
        {
            this.label4.BackColor = Color.FromArgb(30, 193, 120);
            this.label4.ForeColor = Color.White;

        }

        private void BtnHoverOut(object sender, EventArgs e)
        {
            this.label3.BackColor = Color.FromArgb(30, 193, 120);
            this.label3.ForeColor = Color.White;
        }
        private void BtnHoverOut2(object sender, EventArgs e)
        {
            this.label4.BackColor = Color.White;
            this.label4.ForeColor = Color.FromArgb(30, 193, 120);
        }

        
        private void label4_Click(object sender, EventArgs e)
        {
            Form2 Speech2Text = new Form2();

            Speech2Text.Show();
            this.Hide();

        }
        
        private void label7_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form3 Text2Speech = new Form3();

            Text2Speech.Show();
            this.Hide();
        }
        
    }
}
