using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer_Midi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private System.Media.SoundPlayer player = null;
        private void StopSound()
        {
            
            if (player != null)
            {
                player.Stop();
                player.Dispose();
                player = null; //音が止まってることを示している
            }
        }

        private void PlaySound(string waveFile)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(waveFile);
            if (player != null)
                StopSound();

            if (checkBox1.Checked == true)
            {
                player.PlayLooping(); //ループ再生
            }
            else
            {
                player.Play(); //再生
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                PlaySound(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "ファイルを選択...";
            ofd.InitialDirectory = @"C:\";
            ofd.Filter =
    "全ての音楽ファイル(*.wav;*.wave;*.midi;*.mid;*.mp3;*.mpg)|*.wav;*.wave;*.midi;*.mid;*.mp3;*.mpg|MIDIファイル(*.midi;*.mid)|*.midi;*.mid|MP3ファイル(*.mp3;*.mpg)|*.mp3;*.mpg|すべてのファイル(*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            ofd.Multiselect = true;
            ofd.ShowHelp = true;
            ofd.ShowReadOnly = true;
            ofd.ReadOnlyChecked = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = (ofd.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StopSound();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dispose();
            Application.Exit();
        }
    }
}
