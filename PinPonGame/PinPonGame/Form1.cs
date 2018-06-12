using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinPonGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
           

        }
        Random rand = new Random();

        private void Form1_Keydown(object sender, KeyEventArgs e)
        {
            int x = label5.Location.X;
            int y = label5.Location.Y;
            if(e.KeyCode == Keys.W)
            {
                y = y - 20;
                label5.Location = new Point(x, y);

            }
            if (e.KeyCode == Keys.S)
            {
                y = y + 20;
                label5.Location = new Point(x, y);

            }//for firstPlayer
            int a = label6.Location.X;
            int b = label6.Location.Y;
            if (e.KeyCode == Keys.Up)
            {
                b = b - 20;
                label6.Location = new Point(a, b);

            }
            if (e.KeyCode == Keys.Down)
            {
                b = b + 20;
                label6.Location = new Point(a, b);

            }//for secondPlayer
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int ball1 = rand.Next(10,14);
            fireball.Left = fireball.Left + ball1;
            if (label6.Bottom >= fireball.Top && label6.Top <= fireball.Bottom && label6.Right >= fireball.Left && label6.Left <= fireball.Right)
            {
                timer1.Enabled = false; timer2.Enabled = true;
            }
         
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int ball1 = rand.Next(10,16);
            fireball.Left = fireball.Left - ball1;
            if(label5.Top <= fireball.Bottom && label5.Bottom >= fireball.Top && label5.Left <= fireball.Right && label5.Right>= fireball.Left)
            {
                timer2.Enabled = false;  timer3.Enabled = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int top1 = rand.Next(10, 10);
            fireball.Top = fireball.Top + top1;
            if(fireball.Bottom > label4.Top)
            {
                timer3.Enabled = false; timer4.Enabled = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int top1 = rand.Next(10, 15);
            fireball.Top = fireball.Top - top1;


            if(fireball.Top < label3.Bottom)
            {
                timer4.Enabled = false;
     
                timer5.Enabled = true;
            }
           
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            int top1 = rand.Next(10, 15);
            fireball.Top = fireball.Top - top1;


            if (fireball.Left < label1.Right)
            {
                timer5.Enabled = false;
                fireball.Visible = false;
                MessageBox.Show("Second Player Wim !!");
            }
            if(fireball.Right > label2.Left)
            {
                timer5.Enabled = false;
                fireball.Visible = false;
                MessageBox.Show("First Player Win");

            }

        }
    }
}
