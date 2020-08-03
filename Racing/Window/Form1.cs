using Racing.Window;
using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
namespace Racing
{
    public partial class Racing : Form
    {
        SoundPlayer gameSound;
        SoundPlayer game1Sound;
        readonly string[] file = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.wav", SearchOption.AllDirectories);
        public Racing()
        {
           InitializeComponent();
         }
        private int gamespeed = 0;
        private int maxspeed = 8;
        private int minspeed = 0;
        Random rand = new Random();
        private int x;
        private int count = 0;

        private void MoveS(int speed)
        {

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else { pictureBox2.Top += speed; }
            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else { pictureBox3.Top += speed; }
            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else { pictureBox4.Top += speed; }
            if (pictureBox6.Top >= 500)
            {
                pictureBox6.Top = 0;
            }
            else { pictureBox6.Top += speed; }
        }
        private void CoinsCount()
        {
            if (pictureBox1.Bounds.IntersectsWith(money1.Bounds))
            {
                count++;
                label1.Text = "Money=" + count.ToString();
                x = rand.Next(10, 350);
                if(money1.Bounds.Contains(money2.Bounds)|| money1.Bounds.Contains(enemy1.Bounds)|| money1.Bounds.Contains(enemy2.Bounds)|| money1.Bounds.Contains(enemy3.Bounds)|| money1.Bounds.Contains(enemy4.Bounds))
                {
                    x = rand.Next(10, 350);
                    money1.Location = new Point(x, 0);
                }
                else
                {
                    x = rand.Next(10, 350);
                    money1.Location = new Point(x, 0);
                }
            }
            if (pictureBox1.Bounds.IntersectsWith(money2.Bounds))
            {
                count++;
                label1.Text = "Money=" + count.ToString();
                x = rand.Next(10, 350);
                if (money2.Bounds.Contains(money1.Bounds)  || money2.Bounds.Contains(enemy1.Bounds) || money2.Bounds.Contains(enemy2.Bounds) || money2.Bounds.Contains(enemy3.Bounds) || money2.Bounds.Contains(enemy4.Bounds))
                {
                    x = rand.Next(10, 350);
                    money2.Location = new Point(x, 0);
                }
                else
                {
                    x = rand.Next(10, 350);
                    money2.Location = new Point(x, 0);
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveS(gamespeed);
            enemy(gamespeed);
            coins(gamespeed);
            CoinsCount();
            Accident();
        }
        private void Accident()
        {
            if (pictureBox1.Bounds.IntersectsWith(enemy1.Bounds) || pictureBox1.Bounds.IntersectsWith(enemy2.Bounds) || pictureBox1.Bounds.IntersectsWith(enemy3.Bounds) || pictureBox1.Bounds.IntersectsWith(enemy4.Bounds))
            {
                gameSound.PlaySync();
                timer1.Enabled = false;
                label1.Visible = false;
                label2.Visible = true;
                label2.Text = $"Scope: {count}";
                EndGame1.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                gamespeed = 0;
            }
        }
        private void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = rand.Next(170, 300); 
                if(enemy1.Bounds.Contains(enemy2.Bounds)|| enemy1.Bounds.Contains(enemy3.Bounds) || enemy1.Bounds.Contains(enemy4.Bounds) || enemy1.Bounds.Contains(money1.Bounds) || enemy1.Bounds.Contains(money2.Bounds) )
                {
                    x = rand.Next(170, 300);
                    enemy1.Location = new Point(x, 0);
                }
                else
                {
                    x = rand.Next(170, 350);
                    enemy1.Location = new Point(x, 0);
                }
            }
            else { enemy1.Top += speed; }
            if (enemy2.Top >= 500)
            {
                x = rand.Next(300, 350);
                if (enemy2.Bounds.Contains(enemy1.Bounds) || enemy2.Bounds.Contains(enemy3.Bounds) || enemy2.Bounds.Contains(enemy4.Bounds) || enemy2.Bounds.Contains(money1.Bounds) || enemy2.Bounds.Contains(money2.Bounds) )
                {
                    x = rand.Next(300, 350);
                    enemy2.Location = new Point(x, 0);
                }
                else
                {
                    x = rand.Next(300, 350);
                    enemy2.Location = new Point(x, 0);
                }
                
            }
            else { enemy2.Top += speed; }
            if (enemy3.Top >= 500)
            {
                x = rand.Next(80, 130);
                if (enemy3.Bounds.Contains(enemy1.Bounds) || enemy3.Bounds.Contains(enemy2.Bounds) || enemy3.Bounds.Contains(enemy4.Bounds)||enemy3.Bounds.Contains(money1.Bounds)|| enemy3.Bounds.Contains(money2.Bounds))
                {
                    x = rand.Next(80, 130);
                    enemy3.Location = new Point(x, 0);
                }
                else
                {
                    x = rand.Next(70, 130);
                    enemy3.Location = new Point(x, 0);
                }
            }
            else { enemy3.Top += speed; }
            if (enemy4.Top >= 500)
            {
                x = rand.Next(10, 60);
                if (enemy4.Bounds.Contains(enemy1.Bounds) || enemy4.Bounds.Contains(enemy2.Bounds) || enemy4.Bounds.Contains(enemy3.Bounds))
                {
                    x = rand.Next(10, 60);
                    enemy4.Location = new Point(x, 0);
                }
                else
                {
                    x = rand.Next(10, 60);
                    enemy4.Location = new Point(x, 0);
                }
            }
            else { enemy4.Top += speed; }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                
                if (pictureBox1.Left > 15)
                    pictureBox1.Left += -(gamespeed + 5);
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                
                if (pictureBox1.Right < 385)
                    pictureBox1.Left += gamespeed + 5;
            }
            if (e.KeyData == Keys.Up || e.KeyCode == Keys.W)
            {
                if (gamespeed < maxspeed)
                    gamespeed++;
            }
            if (e.KeyData == Keys.Down || e.KeyCode == Keys.S)
            {
                if (gamespeed > minspeed)
                    gamespeed--;
            }
        }
        void coins(int speed)
        {
            if (money1.Top >= 500)
            {
                x = rand.Next(10, 350);
                if (money1.Bounds.Contains(money1.Bounds) || money1.Bounds.Contains(enemy1.Bounds) || money1.Bounds.Contains(enemy2.Bounds) || money1.Bounds.Contains(enemy3.Bounds) || money1.Bounds.Contains(enemy4.Bounds))
                {
                    x = rand.Next(10, 350);
                    money1.Location = new Point(x, 0);
                }
                
            }
            else { money1.Top += speed; }
            if (money2.Top >= 500)
            {
                x = rand.Next(10, 350);
                if (money2.Bounds.Contains(money1.Bounds) || money2.Bounds.Contains(enemy1.Bounds) || money2.Bounds.Contains(enemy2.Bounds) || money2.Bounds.Contains(enemy3.Bounds) || money2.Bounds.Contains(enemy4.Bounds))
                {
                    x = rand.Next(10, 350);
                    money2.Location = new Point(x, 0);
                }
            }
            else { money2.Top += speed; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
            this.Close();
            Racing racing = new Racing();
            racing.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Main_menu menu = new Main_menu();
            menu.Show();
        }

        private void Racing_Load(object sender, EventArgs e)
        {
            int i = rand.Next(3, 6);
            game1Sound = new SoundPlayer(file[i]);
            game1Sound.Play();
            gameSound = new SoundPlayer(file[2]);
            timer1.Start();
            EndGame1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            label2.Visible = false;
        }
    }
}
