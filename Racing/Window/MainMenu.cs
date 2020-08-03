using System;
using System.IO;
using System.Media;
using System.Windows.Forms;
namespace Racing.Window
{
    public partial class Main_menu : Form
    {
        SoundPlayer simpleSound;
        SoundPlayer buttonSample;
        readonly string [] file = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.wav", SearchOption.AllDirectories);
         public Main_menu()
        {
            simpleSound = new SoundPlayer(file[1]);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonSample.PlaySync();
            Racing racing = new Racing();
            this.Hide();
            simpleSound.Stop();
            racing.ShowDialog();
        }

        private void Main_menu_Load(object sender, EventArgs e)
        {
            OnMusic.Visible = false;
            buttonSample = new SoundPlayer(file[0]);
            simpleSound.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CloseW();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            simpleSound.Stop();
            buttonSample.PlaySync();
            О_программе info = new О_программе();
            this.Hide();
            info.ShowDialog(); 
            this.Show();
           
        }
        void CloseW()
        {
            DialogResult dialog = MessageBox.Show(
            "Do you really want to quit the game ?",
            "Program completion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
            );
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void offMusic_Click(object sender, EventArgs e)
        {
            simpleSound.Stop();
            buttonSample.Stop();
            offMusic.Visible = false;
            OnMusic.Visible = true;
        }
        private void OnMusic_Click(object sender, EventArgs e)
        {
            simpleSound.Play();
            OnMusic.Visible = false;
            offMusic.Visible = true;
        }
    }
}
