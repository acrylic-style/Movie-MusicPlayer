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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("winmm.dll",
    CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int mciSendString(string command,
   System.Text.StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

        private string aliasName = "MediaFile";


        private void button4_Click(object sender, EventArgs e)
        {
            Dispose();
            Application.Exit();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // string playing = "false";
            
            {
                string cmd;
                string fileName = textBox1.Text;
                cmd = "open \"" + fileName + "\" alias " + aliasName;
                if (mciSendString(cmd, null, 0, IntPtr.Zero) != 0)
                    return;
                // 再生する
                    cmd = "play " + aliasName;
                    mciSendString(cmd, null, 0, IntPtr.Zero);
                // playing = "true";
                Text = "音楽プレーヤー - 再生中";

                    if (checkBox1.Checked == true)
                    {
                    while (true)

                    {

                            cmd = "stop " + aliasName;
                        mciSendString(cmd, null, 0, IntPtr.Zero);
                        
                        // 再生する

                        cmd = "play " + aliasName;
                        mciSendString(cmd, null, 0, IntPtr.Zero);
                        continue;
                        
                    }
                    
                    }
                        else
                    {
                   // cmd = "stop " + aliasName;
                   // mciSendString(cmd, null, 0, IntPtr.Zero);
                   // Text = "音楽プレーヤー";
                    }
                  
                }
           }
        
        private void button3_Click(object sender, EventArgs e)
        {
            string cmd;
            cmd = "stop " + aliasName;
            mciSendString(cmd, null, 0, IntPtr.Zero);
            //閉じる
            cmd = "close " + aliasName;
            mciSendString(cmd, null, 0, IntPtr.Zero);
            Text = "音楽プレーヤー";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            player.settings.setMode("loop", true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Reset();
            d.DefaultExt = ".mp3";
            if (textBox2.Text == "ここに↑の初期フォルダーを入力してください, わからない方はそのままで")
            {
                d.InitialDirectory = "C:\\Users\\" + Environment.UserName + "\\Desktop";
            }
            else
            {
                d.InitialDirectory = textBox2.Text;
            }
                d.Title = "ファイルを選択";
            d.SupportMultiDottedExtensions = true;
            d.FilterIndex = 1;
            d.Filter =
    "全ての音楽ファイル(*.wav;*.wave;*.midi;*.mid;*.mp3;*.mpg)|*.wav;*.wave;*.midi;*.mid;*.mp3;*.mpg|MIDIファイル(*.midi;*.mid)|*.midi;*.mid|MP3ファイル(*.mp3;*.mpg)|*.mp3;*.mpg|すべてのファイル(*.*)|*.*";
            if (d.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = d.FileName;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                string cmd;
                string fileName = textBox1.Text;
                cmd = "open \"" + fileName + "\" alias " + aliasName;
                if (mciSendString(cmd, null, 0, IntPtr.Zero) != 0)
                    return;
                // 一度停止する
                cmd = "stop " + aliasName;
                mciSendString(cmd, null, 0, IntPtr.Zero);
                // playing = "true";
                Text = "音楽プレーヤー - 再生中";
                cmd = "start " + aliasName;
                mciSendString(cmd, null, 0, IntPtr.Zero);
            }
            else
            {
                // 何もしない
            }
            player.URL = textBox1.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            player.settings.autoStart = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            textBox2.Text = "ここに↑の初期フォルダーを入力してください, わからない方はそのままで";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialogクラスのインスタンスを作成
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            //上部に表示する説明テキストを指定する
            fbd.Description = "フォルダを指定してください。";
            //ルートフォルダを指定する
            //デフォルトでDesktop
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            //最初に選択するフォルダを指定する
            //RootFolder以下にあるフォルダである必要がある
            fbd.SelectedPath = @"C:\Users\" + Environment.UserName;
            //ユーザーが新しいフォルダを作成できるようにする
            //デフォルトでTrue
            fbd.ShowNewFolderButton = true;
            fbd.ShowDialog(this);
            textBox2.Text = fbd.SelectedPath;
            fbd.Dispose();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Enabled == true)
            {
                this.TopMost = !this.TopMost;
            }
        }

        private void player_Enter(object sender, EventArgs e)
        {
            player.URL = textBox1.Text;
        }
    }
}
