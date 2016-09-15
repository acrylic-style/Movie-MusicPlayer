﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

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
   StringBuilder buffer, int bufferSize, IntPtr hwndCallback);


        public static int arguments(string[] args)
        {
            AxWMPLib.AxWindowsMediaPlayer player = new AxWMPLib.AxWindowsMediaPlayer();
            if (args.Length != 1)
            {
                Console.Write("引数の値がおかしいです。実行できません。");
                return -1;
            }
            try
            {
                player.settings.autoStart = true;
                player.settings.setMode("loop", true);
                player.URL = args[0]; // Set Player URL
                player.Show();
                
                
            }
            catch (Exception e)
            {
                Console.Write(e.Message+"\n");
            }

            return 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Dispose();
            Application.Exit();
        }

        /* // Deprecated
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
            while (true)
            {
                
            }


           }
        


        private void Player_Invalidated(object sender, InvalidateEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cmd;
            cmd = "stop " + aliasName;
            mciSendString(cmd, null, 0, IntPtr.Zero);
            //閉じる
            cmd = "close " + aliasName;
            mciSendString(cmd, null, 0, IntPtr.Zero);
        }
        */
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            player.settings.setMode("loop", true);
        }
        /* Deprecated
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            
        }*/

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Reset(); // initial dialog box
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
    "全てのサポートされるタイプ(*.wav;*.wave;*.midi;*.mid;*.mp3;*.mpg;*.midi;*.mid;*.m4a;*.avi;*.mp4;*.mpeg;*.ogg;*.vob;*.mov;*.wma;*.asf;*.asx;*.wax;*.wm;*.wmv;*.wvx;*.rmi)|*.wav;*.wave;*.midi;*.mid;*.mp3;*.mpg;*.midi;*.mid;*.m4a;*.avi;*.mp4;*.mpeg;*.ogg;*.vob;*.mov;*.wma;*.asf;*.asx;*.wax;*.wm;*.wmv;*.wvx;*.rmi|全ての動画ファイル(*.avi;*.mp4;*.mpeg;*.vob;*.mov;*.wma;*.asf;*.asx;*.wax;*.wm;*.wmv;*.wvx)|*.avi;*.mp4;*.mpeg;*.vob;*.mov;*.wma;*.asf;*.asx;*.wax;*.wm;*.wmv;*.wvx|全ての音楽ファイル(*.wav;*.wave;*.midi;*.mid;*.mp3;*.mpg;*.midi;*.mid;*.m4a)|*.wav;*.wave;*.midi;*.mid;*.mp3;*.mpg;*.midi;*.mid;*.m4a|MP3ファイル(*.mp3;*.mpg)|*.mp3;*.mpg|すべてのファイル(*.*)|*.*";
            if (d.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = d.FileName;
            }
            
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                player.URL = textBox1.Text;
            }
            catch (Exception exp)
            {
                MessageBox.Show("テキストボックスの中が不正な値のため、操作に失敗しました。詳細情報：" + exp, "エラーが発生しました", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(textBox1.Text != null)
            {
                button1.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Enabled == true)
            {
                player.settings.autoStart = true;
            }
            else
            {
                player.settings.autoStart = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            player.settings.autoStart = false;
            
            player.settings.volume = 100;
            textBox2.Text = "ここに↑の初期フォルダーを入力してください, わからない方はそのままで";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string default_dir = textBox2.Text;
            
            var Dialog = new CommonOpenFileDialog();
            Dialog.IsFolderPicker = true;
            Dialog.EnsureReadOnly = true;
            Dialog.AllowNonFileSystemItems = false;
            Dialog.DefaultDirectory = default_dir;
            var Result = Dialog.ShowDialog();

            if (Result == CommonFileDialogResult.Ok)
            {
                textBox2.Text = Dialog.FileName;
            }
            Dialog.Dispose();
            
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

        private void label1_Click(object sender, EventArgs e)
        {
            // Deprecated
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("自動再生がバグるかもしれない", "WMP仕様上の注意(?)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            try
            {
                player.openPlayer(textBox1.Text);
            }
            
            catch
            {
                try
                {
                    player.openPlayer(player.URL);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("テキストボックスは、nullではないですが、表示ができないため、エラーです。詳細情報：" + ex, "エラーが発生しました", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    public partial class Form2 : Form
    {
        // test
    }
}
