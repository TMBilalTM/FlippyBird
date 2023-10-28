using System;
using System.Windows.Forms;

namespace FlippyBird
{
    public partial class Form1 : Form
    {
        int hız = 9,bitir=0;
        int gravity = 10;
        bool basla = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
            if (basla == false && e.KeyCode == Keys.Space)
            {
                basla = true;
                timer1.Start();
            }
            if (e.KeyCode == Keys.Space)
            {
                gravity = -6;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 6;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (basla == true)
            {
                button2.Visible = false;
                button2.Enabled = false;
                pictureBox1.Top += gravity;
                pictureBox2.Left -= hız;
                pictureBox3.Left -= hız;
                pictureBox4.Left -= hız;
                pictureBox5.Left -= hız;
                pictureBox6.Left -= hız;
                pictureBox7.Left -= hız;
                if (pictureBox2.Left < -150)
                {
                    pictureBox2.Left = 700;
                }
                if (pictureBox3.Left < -150)
                {
                    pictureBox3.Left = 700;
                }

                if (pictureBox4.Left < -150)
                {
                    pictureBox4.Left = 700;
                }
                if (pictureBox5.Left < -150)
                {
                    pictureBox5.Left = 700;
                }

                if (pictureBox6.Left < -150)
                {

                    pictureBox6.Left = 700;
                }
                if (pictureBox7.Left < -150)
                {
                    pictureBox7.Left = 700;
                }
                if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds)
                    || pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds)
                    || pictureBox1.Bounds.IntersectsWith(pictureBox4.Bounds)
                    || pictureBox1.Bounds.IntersectsWith(pictureBox5.Bounds)
                     || pictureBox1.Bounds.IntersectsWith(pictureBox6.Bounds)
                      || pictureBox1.Bounds.IntersectsWith(pictureBox7.Bounds))

                {
                    bitir = 1;
                    Bitir();
                }
                if (pictureBox1.Top < -25 || pictureBox1.Top > 500)
                {
                    bitir = 2;
                    Bitir();
                }

            }
        }
        private void Bitir()
        {
            if(bitir == 1)
            {
                timer1.Stop();
                label1.Text = "Duvara çarptın ahmak!";
                label1.Visible = true;
                button1.Visible = true;
                button1.Enabled = true;
            }
            if (bitir == 2)
            {
                timer1.Stop();
                label1.Text = "Hop nereye?!";
                label1.Visible = true;
                button1.Visible = true;
                button1.Enabled = true;

            }
            timer1.Stop();
            label1.Visible = true;
            button1.Visible = true;
            button1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = true;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            basla = true;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form1 frm2 = new Form1();
            frm2.Show();
            this.Hide();
        }
    }
}
