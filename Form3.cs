using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat
{
    public partial class Form3 : Form
    {
        int speed = -20;
        public Form3()
        {
            InitializeComponent();
            over.Hide();
            button1.Hide();
            button2.Hide();
           
        }

        int x, y, z;

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void score_Click(object sender, EventArgs e)
        {

        }

        private void sonic_Click(object sender, EventArgs e)
        {

        }

        private void bullet_Click(object sender, EventArgs e)
        {

        }

        private void over_Click(object sender, EventArgs e)
        {

        }

        private void e2_Click(object sender, EventArgs e)
        {

        }

        private void e3_Click(object sender, EventArgs e)
        {

        }


        private void enemy()
        {
            Random rnd = new Random();

            if (e1.Top < 0)
            {
                x = rnd.Next(20, 290);
                e1.Location = new Point(x, 400);
            }
            if (e2.Top < 0)
            {
                y = rnd.Next(20, 290);
                e2.Location = new Point(y, 4000);
            }
            if (e3.Top < 0)
            {
                z = rnd.Next(20, 290);
                e3.Location = new Point(z, 400);
            }

            if (e4.Top < 0)
            {
                z = rnd.Next(20, 290);
                e3.Location = new Point(z, 400);
            }

            if (e5.Top < 0)
            {
                z = rnd.Next(20, 290);
                e3.Location = new Point(z, 400);
            }
            else
            {
                e1.Top -= 4;
                e2.Top -= 6;
                e3.Top -= 7;
                e4.Top -= 5;
                e5.Top -= 3;
                

            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)

            {
                if (sonic.Left > 20)
                    sonic.Left -= 45;
            }

            {
                if (e.KeyCode == Keys.Right)
                {
                    if (sonic.Left < 290)
                        sonic.Left += 45;
                }

                if (e.KeyCode == Keys.Up)
                {
                    if (sonic.Top > 0)
                        sonic.Top -= 45;
                }

                if (e.KeyCode == Keys.Down)
                {
                    if (sonic.Top < 400)
                        sonic.Top += 45;
                }
            }

        }

       
        private void ex()
        {
            if (e1.Bounds.IntersectsWith(sonic.Bounds))
            {
              
                e1.Top = 600;

                sc += 5;
                score.Text = "Score:" + sc;

            }
            if (e2.Bounds.IntersectsWith(sonic.Bounds))
            {
                e2.Top = 600;

                sc += 5;
                score.Text = "Score:" + sc;
            }
            if (e3.Bounds.IntersectsWith(sonic.Bounds))
            {
                timer1.Stop();
                over.Show();
                button1.Show();
                button2.Show();
            }
            if (e4.Bounds.IntersectsWith(sonic.Bounds))
            {
                e4.Top = 600;

                sc += 5;
                score.Text = "Score:" + sc;
            }
            if (e5.Bounds.IntersectsWith(sonic.Bounds))
            {
                e5.Top = 600;

                sc += 5;
                score.Text = "Score:" + sc;
            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        int sc = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            enemy();
            ex();

        }

        
        


    }

}
