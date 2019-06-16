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
using System.IO;

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

        [System.Runtime.InteropServices.DllImport("winmm.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

        public static void InitDiscordRPC()
        {
            client = new DiscordRpcClient("576128781211664394");

            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.OnReady += (sender, e) =>
            {
                Console.WriteLine("Received Ready from user {0}", e.User.Username);
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update! {0}", e.Presence);
            };

            client.Initialize();
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
                Console.Write("You passed wrong arguments count.");
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
            d.Title = "Select files...";

            player.currentPlaylist.appendItem(player.newMedia(""));

            d.SupportMultiDottedExtensions = true;
            d.FilterIndex = 1;
            d.Filter =
    "All Supported Files(*.mod;*.wav;*.wave;*.midi;*.mid;*.mp3;*.mpg;*.midi;*.mid;*.m4a;*.avi;*.mp4;*.mpeg;*.ogg;*.vob;*.mov;*.wma;*.asf;*.asx;*.wax;*.wm;*.wmv;*.wvx;*.rmi;*.cda;*.mkv)|*.mod;*.wav;*.wave;*.midi;*.mid;*.mp3;*.mpg;*.midi;*.mid;*.m4a;*.avi;*.mp4;*.mpeg;*.ogg;*.vob;*.mov;*.wma;*.asf;*.asx;*.wax;*.wm;*.wmv;*.wvx;*.rmi;*.cda;*.mkv|All Files(*.*)|*.*";
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
                pictureBox1.Enabled = true;
                trackBar2.Enabled = true;
                AddNextMedia.Enabled = true;
                AddNextMedia.Text = "Add next media";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddNextMedia.Enabled = false;
            AddNextMedia.Text = "Add next media";
            player.settings.autoStart = false;
            status.Text = "Status: Not playing anything";
            player.settings.volume = 100;

            trackBar2.Enabled = false;

            player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(player_PlayStateChange);
        }

        public void MediaChangedEvent(object sender, EventArgs e)
        {
            player.CurrentItemChange += Player_CurrentItemChange;
        }

        private void Player_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            // Finally unused
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
                    d.Description = "Select a folder!";
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
                    MessageBox.Show("A unknown error has thrown.", "oof", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            // Unused
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
            // Unused
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // Unused
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
                    MessageBox.Show("Unable to open player: " + ex, "AAA! Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            play();
        }

        private void updateStatus(string smallKey = "playing")
        {
            status.Text = "Status: " + player.status;
            TagLib.File file = TagLib.File.Create(player.currentMedia.sourceURL);
            string deftitle = player.currentMedia.sourceURL.Split('\\')[player.currentMedia.sourceURL.Split('\\').Length - 1].Replace(".mp3", "");
            client.SetPresence(new RichPresence()
            {
                Details = file.Tag.Title != null ? (file.Tag.Title.Length != 0 ? file.Tag.Title : deftitle) : deftitle,
                State = (file.Tag.AlbumArtists.Length != 0 ? (file.Tag.AlbumArtists[0].Length != 0 ? "by "+file.Tag.AlbumArtists[0] : null) : null),
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = "groove",
                    LargeImageText = "Playing " + player.currentMedia.sourceURL.Split('\\')[player.currentMedia.sourceURL.Split('\\').Length - 2],
                    SmallImageKey = smallKey,
                    SmallImageText = "Playing " + player.currentMedia.sourceURL.Split('\\')[player.currentMedia.sourceURL.Split('\\').Length - 1],
                }
            });
            name.Text = "Name: " + player.currentMedia.name;
            url.Text = "URL: " + player.currentMedia.sourceURL;
        }

        private void play()
        {
            player.Ctlcontrols.play();
            updateStatus();
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
            status.Text = "Status: " + player.status;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (Volume.Value > 50) pictureBox5.Image = Movie_MusicPlayer.Properties.Resources.volume_high;
            else if (Volume.Value < 50) pictureBox5.Image = Movie_MusicPlayer.Properties.Resources.volume_low;
            else if (Volume.Value == 0) pictureBox5.Image = Movie_MusicPlayer.Properties.Resources.volume_off;
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
            updateStatus("pause");
            player.Ctlcontrols.pause();
            status.Text = "Status: " + player.status;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.previous();
            updateStatus();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.next();
            updateStatus();
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
                MessageBox.Show("An unexpected error occurred: \nDetails:\n" + e1, "AAAA! Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void speed_TextChanged(object sender, EventArgs e)
        {
            if (speed.Text != "")
            {
                try
                {
                    double result;
                    if (double.TryParse(speed.Text, out result)) player.settings.rate = result;
                }

                catch (Exception e1)
                {
                    // Ignore error, this error should not happen
                }
            }
        }

        private void button_13(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Reset(); // initial dialog box
            d.Title = "Select files...";

            d.SupportMultiDottedExtensions = true;
            d.Multiselect = true;
            d.FilterIndex = 1;
            d.Filter =
    "All Supported Files(*.wav;*.wave;*.midi;*.mid;*.mp3;*.mpg;*.midi;*.mid;*.m4a;*.avi;*.mp4;*.mpeg;*.ogg;*.vob;*.mov;*.wma;*.asf;*.asx;*.wax;*.wm;*.wmv;*.wvx;*.rmi;*.cda;*.mkv)|*.wav;*.wave;*.midi;*.mid;*.mp3;*.mpg;*.midi;*.mid;*.m4a;*.avi;*.mp4;*.mpeg;*.ogg;*.vob;*.mov;*.wma;*.asf;*.asx;*.wax;*.wm;*.wmv;*.wvx;*.rmi;*.cda;*.mkv|All Files(*.*)|*.*";
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
            switch (e.newState) {
                case (int)WMPLib.WMPPlayState.wmppsMediaEnded: stop(); break;
                case (int)WMPLib.WMPPlayState.wmppsPlaying: updateStatus(); break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] music = Directory.GetFiles(textBox2.Text, "*.mp3");
            foreach (string musicurl in music)
            {
                if (musicurl.Length == 0) continue;
                Console.WriteLine("Detected File: " + musicurl);
                player.currentPlaylist.appendItem(player.newMedia(musicurl));
            }
            if (music.Length == 0)
            {
                string[] dirs = Directory.GetDirectories(textBox2.Text);
                if (dirs.Length == 0) return;
                dirs = dirs.OrderBy(i => Guid.NewGuid()).ToArray();
                foreach (string dir in dirs)
                {
                    music = Directory.GetFiles(dir, "*.mp3");
                    foreach (string musicurl in music)
                    {
                        if (musicurl.Length == 0) continue;
                        Console.WriteLine("Detected File: " + musicurl);
                        player.currentPlaylist.appendItem(player.newMedia(musicurl));
                    }
                }
            }
            trackBar2.Enabled = true;
            AddNextMedia.Enabled = true;
            AddNextMedia.Text = "Add Next Media";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            player.currentPlaylist.clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Tag.ToString() == "play") {
                play();
                pictureBox1.Tag = "pause";
                pictureBox1.Image = Movie_MusicPlayer.Properties.Resources.pause;
            }
            else if (pictureBox1.Tag.ToString() == "pause")
            {
                updateStatus("pause");
                player.Ctlcontrols.pause();
                status.Text = "Status: " + player.status;
                pictureBox1.Tag = "play";
                pictureBox1.Image = Movie_MusicPlayer.Properties.Resources.playing;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Tag.ToString() == "False")
            {
                pictureBox4.BackColor = SystemColors.ControlDarkDark;
                pictureBox4.Image = Movie_MusicPlayer.Properties.Resources.repeat_one;
                pictureBox4.Tag = "Loop";
                player.settings.setMode("loop", true);
            }
            else if (pictureBox4.Tag.ToString() == "Loop")
            {
                pictureBox4.BackColor = SystemColors.ControlDark;
                pictureBox4.Image = Movie_MusicPlayer.Properties.Resources.repeat;
                pictureBox4.Tag = "False";
                player.settings.setMode("loop", false);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.next();
            updateStatus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.previous();
            updateStatus();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Tag.ToString() == "False")
            {
                pictureBox6.BackColor = SystemColors.ControlDarkDark;
                pictureBox6.Tag = "True";
                player.Ctlcontrols.fastForward();
            }
            else
            {
                pictureBox6.BackColor = SystemColors.ControlDark;
                pictureBox6.Tag = "False";
                player.Ctlcontrols.play();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Tag.ToString() == "False")
            {
                pictureBox6.BackColor = SystemColors.ControlDarkDark;
                pictureBox6.Tag = "True";
                player.Ctlcontrols.fastReverse();
            }
            else
            {
                pictureBox6.BackColor = SystemColors.ControlDark;
                pictureBox6.Tag = "False";
                player.Ctlcontrols.play();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            stop();
            pictureBox1.Tag = "play";
            pictureBox1.Image = Movie_MusicPlayer.Properties.Resources.playing;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}