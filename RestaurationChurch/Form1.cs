using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurationChurch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x, y;
        bool moove;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moove = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moove = false;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                rectangleShape2.Width += 4;

            if (rectangleShape2.Width >= 447)
            {
             timer1.Stop();
                
               this.Hide();
                DashBoad dash = new DashBoad();
                dash.Show();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moove)
            {
                x = MousePosition.X - 400;
                y = MousePosition.Y - 40;
                SetDesktopLocation(x, y);

            }

        
        }
    }
}
