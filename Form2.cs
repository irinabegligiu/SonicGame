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
    public partial class Form2 : Form
    {
        public Form2()
        {


            InitializeComponent();
            over.Hide();
            congrats.Hide();
            button1.Hide();
            button2.Hide();
          
        }
        int x, y, z;

        private void e2_Click(object sender, EventArgs e)
        {

        }

        private void e1_Click(object sender, EventArgs e)
        {

        }

        private void e3_Click(object sender, EventArgs e)
        {

        }

        private void over_Click(object sender, EventArgs e)
        {

        }

        private void congrats_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 openForm = new Form3();
            openForm.Show();
            this.Hide();
        }

        private void bullet_Click(object sender, EventArgs e)
        {

        }

        private void sonic_Click(object sender, EventArgs e)
        {

        }



        private void score_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void enemy()
        {
            Random rnd = new Random();

            if (e1.Top > 400)
            {
                x = rnd.Next(0, 50);
                e1.Location = new Point(x, 0);
            }
            if (e2.Top > 400)
            {
                y = rnd.Next(0, 300);
                e2.Location = new Point(y, 0);
            }
            if (e3.Top > 400)
            {
                z = rnd.Next(0, 300);
                e3.Location = new Point(z, 0);
            }
            else
            {
                e1.Top += 4;
                e2.Top += 6;
                e3.Top += 7;
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
            }
        }


        private void blue()

        {
            int speed = 15;
            bullet.Top -= speed;
            if (bullet.Top < 0)
            {
                speed = 30;
                bullet.Left = sonic.Left + 30;
                bullet.Top = sonic.Top;
            }
        }

        private void ex()
        {
            if (e1.Bounds.IntersectsWith(sonic.Bounds))
            {
                timer1.Stop();
                over.Show();
                button2.Show();
            }
            if (e2.Bounds.IntersectsWith(sonic.Bounds))
            {
                timer1.Stop();
                over.Show();
                button2.Show();
            }
            if (e3.Bounds.IntersectsWith(sonic.Bounds))
            {
                timer1.Stop();
                over.Show();
                button2.Show();
            }


        }
        
       
    int sc = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            Application.Exit();
        }

        private void next()
        {
            if (sc == 70)
            {
                congrats.Show();
                button1.Show();
                timer1.Stop();
               
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            enemy();
            ex();
            blue();
            next();
            
            if (e1.Bounds.IntersectsWith(bullet.Bounds))
            {
                e1.Top = 500;
                sc += 5;
                score.Text = "Scor:" + sc;
            }
            if (e2.Bounds.IntersectsWith(bullet.Bounds))
            {
                e2.Top = 500;
                sc += 5;
                score.Text = "Scor:" + sc;
            }
            if (e3.Bounds.IntersectsWith(bullet.Bounds))
            {
                e3.Top = 500;
                sc += 5;
                score.Text = "Scor:" + sc;
            }
           

        }
       
    }
}
