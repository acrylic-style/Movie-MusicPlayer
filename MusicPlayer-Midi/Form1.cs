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
            OpenFileDialog d = new OpenFileDialog();
            d.Reset();
            d.DefaultExt = ".mid";
            d.InitialDirectory = Environment.CurrentDirectory;
            d.Title = "ファイルを選択...";
            d.SupportMultiDottedExtensions = true;
            d.ShowDialog();
            d.FilterIndex = 2;
            d.Filter =
    "MIDIファイル(*.midi;*.mid)|*.midi;*.mid|すべてのファイル(*.*)|*.*";

            string fileName = d.FileName;
            string cmd;
            cmd = "open \"" + fileName + "\" alias " + aliasName;
            if (mciSendString(cmd, null, 0, IntPtr.Zero) != 0)
                return;
            //再生する
            cmd = "play " + aliasName;
            mciSendString(cmd, null, 0, IntPtr.Zero);
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
    }
}
