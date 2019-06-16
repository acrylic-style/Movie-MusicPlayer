using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Microsoft.WindowsAPICodePack.Dialogs;
using DiscordRPC;
using DiscordRPC.Logging;

namespace Video_MusicPlayer
{
    public partial class Form1 : Form
    {
        public static DiscordRpcClient client;

        public Form1()
        {
            InitializeComponent();
            InitDiscordRPC();
        }

        [System.Runtime.InteropServices.DllImport("winmm.dll",
    CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int mciSendString(string command,
   StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

        public static void InitDiscordRPC()
        {
            client = new DiscordRpcClient("576128781211664394");

            //Set the logger
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            //Subscribe to events
            client.OnReady += (sender, e) =>
            {
                Console.WriteLine("Received Ready from user {0}", e.User.Username);
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update! {0}", e.Presence);
            };

            //Connect to the RPC
            client.Initialize();

            //Set the rich presence
            //Call this as many times as you want and anywhere in your code.
            client.SetPresence(new RichPresence()
            {
                Details = "Idle",
                Assets = new Assets()
                {
                    LargeImageKey = "groove",
                    SmallImageKey = "stop"
                }
            });
        }

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
                Console.Write(e.Message + "\n");
            }

            return 0;
        }

        /* This is Test area, Do not use this Area!
        private AxWMPLib.AxWindowsMediaPlayer players;

        protected void Drag_Enter(object s,DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        protected void Drag_Drop(object s,DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                foreach (string filename in (string[])e.Data.GetData(DataFormats.FileDrop))
                {
                    player.URL = filename;
                }
            }
        }

        public new DragDrop()
        {
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            
            
        } */

        private void button4_Click(object sender, EventArgs e)
        {

            Dispose();
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            player.settings.setMode("loop", true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Title = "ファイルを選択";

            player.currentPlaylist.appendItem(player.newMedia(""));

            d.SupportMultiDottedExtensions = true;
            d.FilterIndex = 1;
            d.Filter =
    "全てのサポートされるタイプ(*.mod;*.wav;*.wave;*.midi;*.mid;*.mp3;*.mpg;*.midi;*.mid;*.m4a;*.avi;*.mp4;*.mpeg;*.ogg;*.vob;*.mov;*.wma;*.asf;*.asx;*.wax;*.wm;*.wmv;*.wvx;*.rmi;*.cda;*.mkv)|*.mod;*.wav;*.wave;*.midi;*.mid;*.mp3;*.mpg;*.midi;*.mid;*.m4a;*.avi;*.mp4;*.mpeg;*.ogg;*.vob;*.mov;*.wma;*.asf;*.asx;*.wax;*.wm;*.wmv;*.wvx;*.rmi;*.cda;*.mkv|すべてのファイル(*.*)|*.*";
            if (d.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = d.FileName;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            player.URL = textBox1.Text;
            if (textBox1.Text != null)
            {
                OpenMediaPlayer.Enabled = true;
                Fast.Enabled = true;
                Slow.Enabled = true;
                Play.Enabled = true;
                Stop.Enabled = true;
                trackBar2.Enabled = true;
                Pause.Enabled = true;
                Back.Enabled = true;
                Next.Enabled = true;
                AddNextMedia.Enabled = true;
                AddNextMedia.Text = "次の曲を追加";
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
            AddNextMedia.Enabled = false;
            AddNextMedia.Text = "次のメディアを追加";
            OpenMediaPlayer.Enabled = false;
            player.settings.autoStart = false;
            status.Text = "状態: 再生されていません";
            player.settings.volume = 100;
            textBox2.Text = "ここに↑の初期フォルダーを入力してください, わからない方はそのままで";

            Slow.Enabled = false;
            Fast.Enabled = false;
            Play.Enabled = false;
            Stop.Enabled = false;
            trackBar2.Enabled = false;
            Pause.Enabled = false;
            Back.Enabled = false;
            Next.Enabled = false;


        }

        public void MediaChangedEvent(object sender, EventArgs e)
        {
            player.CurrentItemChange += Player_CurrentItemChange;
        }

        private void Player_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            //throw new NotImplementedException();
            // Not Implemented!

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string default_dir = textBox2.Text;
            try
            {
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
            catch
            {
                try
                {
                    FolderBrowserDialog d = new FolderBrowserDialog();
                    d.Description = "フォルダを指定してください。";
                    d.RootFolder = Environment.SpecialFolder.CommonDesktopDirectory;
                    d.SelectedPath = default_dir;
                    d.ShowNewFolderButton = true;
                    if (d.ShowDialog(this) == DialogResult.OK)
                    {
                        textBox2.Text = d.SelectedPath;
                    }
                    d.Dispose();
                }
                catch
                {
                    MessageBox.Show("不明なエラーが発生しました。", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Enabled == true)
            {
                this.TopMost = !this.TopMost;
            }
        }

        private void player_Enter(object sender, EventArgs e)
        {
            player.URL = textBox1.Text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Using AxWMPLib. Bugs can happen! lol", "...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void button2_Click(object sender, EventArgs e)
        {
            play();
        }

        private void play()
        {
            player.Ctlcontrols.play();
            if (player.status != "接続しています...")
            {
                status.Text = "状態:" + player.status;
            }
            else
            {
                status.Text = "状態:" + player.status + " (再生ボタンを再度クリックすると正常に表示されます)";
            }
            TagLib.File file = TagLib.File.Create(player.currentMedia.sourceURL);
            client.SetPresence(new RichPresence()
            {
                Details = file.Tag.Title.Length != 0 ? file.Tag.Title : player.currentMedia.sourceURL.Split('\\')[player.currentMedia.sourceURL.Split('\\').Length - 1],
                State = "by " + (file.Tag.AlbumArtists[0].Length != 0 ? file.Tag.AlbumArtists[0]+" - " : "<?>"),
                Assets = new Assets()
                {
                    LargeImageKey = "groove",
                    LargeImageText = "Playing " + player.currentMedia.sourceURL.Split('\\')[player.currentMedia.sourceURL.Split('\\').Length - 2],
                    SmallImageKey = "playing",
                    SmallImageText = "Playing " + player.currentMedia.sourceURL.Split('\\')[player.currentMedia.sourceURL.Split('\\').Length - 1],
                }
            });
            name.Text = "名前:" + player.currentMedia.name;
            url.Text = "URL:" + player.currentMedia.sourceURL;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stop();
        }

        private void stop()
        {
            client.SetPresence(new RichPresence()
            {
                Details = "Idle",
                Assets = new Assets()
                {
                    LargeImageKey = "groove",
                    SmallImageKey = "stop",
                }
            });
            player.Ctlcontrols.stop();
            status.Text = "状態:" + player.status;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = Volume.Value;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.fastReverse();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.fastForward();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            client.SetPresence(new RichPresence()
            {
                Details = "Playing Music ♬",
                State = "Playing " + player.currentMedia.sourceURL.Split('\\')[player.currentMedia.sourceURL.Split('\\').Length - 1],
                Assets = new Assets()
                {
                    LargeImageKey = "groove",
                    LargeImageText = "Playing " + player.currentMedia.sourceURL.Split('\\')[player.currentMedia.sourceURL.Split('\\').Length - 2],
                    SmallImageKey = "pause",
                    SmallImageText = "Playing " + player.currentMedia.sourceURL.Split('\\')[player.currentMedia.sourceURL.Split('\\').Length - 1],
                }
            });
            player.Ctlcontrols.pause();
            status.Text = "状態:" + player.status;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.previous();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.next();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            try
            {

                double value = double.Parse(speed.Text);
                if (trackBar2.Value == 0) { value = 0.75; speed.Text = "0.75"; }
                if (trackBar2.Value == 1) { value = 1; speed.Text = "1"; }
                if (trackBar2.Value == 2) { value = 1.25; speed.Text = "1.25"; }
                if (trackBar2.Value == 3) { value = 1.5; speed.Text = "1.5"; }
                if (trackBar2.Value == 4) { value = 2; speed.Text = "2"; }
                player.settings.rate = value;

            }
            catch (Exception e1)
            {
                MessageBox.Show("エラーが発生しました。\n詳細情報:\n" + e1, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void speed_TextChanged(object sender, EventArgs e)
        {
            if (speed.Text != "")
            {
                try
                {
                    player.settings.rate = double.Parse(speed.Text);
                }

                catch (Exception e1)
                {

                    MessageBox.Show("エラーが発生しました。\ndouble 値を入力していますか？\n詳細情報:\n" + e1, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void button_13(object sender, EventArgs e)
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
            d.Multiselect = true;
            d.FilterIndex = 1;
            d.Filter =
    "全てのサポートされるタイプ(*.wav;*.wave;*.midi;*.mid;*.mp3;*.mpg;*.midi;*.mid;*.m4a;*.avi;*.mp4;*.mpeg;*.ogg;*.vob;*.mov;*.wma;*.asf;*.asx;*.wax;*.wm;*.wmv;*.wvx;*.rmi;*.cda;*.mkv)|*.wav;*.wave;*.midi;*.mid;*.mp3;*.mpg;*.midi;*.mid;*.m4a;*.avi;*.mp4;*.mpeg;*.ogg;*.vob;*.mov;*.wma;*.asf;*.asx;*.wax;*.wm;*.wmv;*.wvx;*.rmi;*.cda;*.mkv|すべてのファイル(*.*)|*.*";
            if (d.ShowDialog() == DialogResult.OK)
            {
                foreach (string array in d.FileNames)
                {
                    player.currentPlaylist.appendItem(player.newMedia(array));
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            player.currentPlaylist.removeItem(player.currentMedia);
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch (e.newState)
            {
                case (int)WMPLib.WMPPlayState.wmppsPlaying:
                    play();
                    break;

                case (int)WMPLib.WMPPlayState.wmppsMediaEnded:
                    stop();
                    break;

                default:
                    break;
            }
        }
    }
}