namespace Video_MusicPlayer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CloseButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.OpenMediaPlayer = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Slow = new System.Windows.Forms.Button();
            this.Volume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Fast = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.TextBox();
            this.AddNextMedia = new System.Windows.Forms.Button();
            this.RemoteCurrentMedia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(629, 231);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(59, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "閉じる";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(774, 241);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 16);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "リピート";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(579, 212);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(562, 19);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(696, 241);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 16);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "自動再生";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 233);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(562, 19);
            this.textBox2.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(579, 233);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(22, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(774, 219);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(70, 16);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "常に手前";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // player
            // 
            this.player.AllowDrop = true;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 258);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(734, 381);
            this.player.TabIndex = 12;
            this.player.Enter += new System.EventHandler(this.player_Enter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(607, 238);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(16, 12);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "...?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // OpenMediaPlayer
            // 
            this.OpenMediaPlayer.Location = new System.Drawing.Point(608, 212);
            this.OpenMediaPlayer.Name = "OpenMediaPlayer";
            this.OpenMediaPlayer.Size = new System.Drawing.Size(152, 21);
            this.OpenMediaPlayer.TabIndex = 15;
            this.OpenMediaPlayer.Text = "WindowsMediaPlayer";
            this.OpenMediaPlayer.UseVisualStyleBackColor = true;
            this.OpenMediaPlayer.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(12, 3);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(87, 23);
            this.Play.TabIndex = 16;
            this.Play.Text = "再生";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.button2_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(201, 3);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(87, 23);
            this.Stop.TabIndex = 17;
            this.Stop.Text = "停止";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.button3_Click);
            // 
            // Slow
            // 
            this.Slow.Location = new System.Drawing.Point(390, 3);
            this.Slow.Name = "Slow";
            this.Slow.Size = new System.Drawing.Size(87, 23);
            this.Slow.TabIndex = 18;
            this.Slow.Text = "早送り≫";
            this.Slow.UseVisualStyleBackColor = true;
            this.Slow.Click += new System.EventHandler(this.button7_Click);
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(0, 163);
            this.Volume.Maximum = 100;
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(856, 45);
            this.Volume.TabIndex = 19;
            this.Volume.Value = 100;
            this.Volume.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(720, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "↓音量↓　↑2倍速↑";
            // 
            // Fast
            // 
            this.Fast.Location = new System.Drawing.Point(295, 3);
            this.Fast.Name = "Fast";
            this.Fast.Size = new System.Drawing.Size(87, 23);
            this.Fast.TabIndex = 21;
            this.Fast.Text = "≪早戻し";
            this.Fast.UseVisualStyleBackColor = true;
            this.Fast.Click += new System.EventHandler(this.button8_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(106, 3);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(87, 23);
            this.Pause.TabIndex = 22;
            this.Pause.Text = "一時停止";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.button9_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(484, 3);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(87, 23);
            this.Back.TabIndex = 23;
            this.Back.Text = "戻す";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.button10_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(579, 3);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(87, 23);
            this.Next.TabIndex = 24;
            this.Next.Text = "次へ";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.button11_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(12, 32);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(31, 12);
            this.status.TabIndex = 25;
            this.status.Text = "状態:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(12, 54);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(31, 12);
            this.name.TabIndex = 26;
            this.name.Text = "名前:";
            // 
            // url
            // 
            this.url.AutoSize = true;
            this.url.Location = new System.Drawing.Point(14, 75);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(29, 12);
            this.url.TabIndex = 27;
            this.url.Text = "URL:";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(2, 90);
            this.trackBar2.Maximum = 4;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(854, 45);
            this.trackBar2.TabIndex = 28;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(579, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 29;
            this.label2.Text = "1.5倍速↑";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(369, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 30;
            this.label3.Text = "1.25倍速↑";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(176, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 31;
            this.label4.Text = "1倍速↑";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(7, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 32;
            this.label5.Text = "↑0.75倍速";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(665, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 33;
            this.label6.Text = "現在の速度:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(820, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 35;
            this.label7.Text = "倍速";
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(738, 5);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(80, 19);
            this.speed.TabIndex = 36;
            this.speed.Text = "1";
            this.speed.TextChanged += new System.EventHandler(this.speed_TextChanged);
            // 
            // AddNextMedia
            // 
            this.AddNextMedia.Location = new System.Drawing.Point(686, 71);
            this.AddNextMedia.Name = "AddNextMedia";
            this.AddNextMedia.Size = new System.Drawing.Size(168, 21);
            this.AddNextMedia.TabIndex = 37;
            this.AddNextMedia.Text = "次のメディアを追加";
            this.AddNextMedia.UseVisualStyleBackColor = true;
            this.AddNextMedia.Click += new System.EventHandler(this.button_13);
            // 
            // RemoteCurrentMedia
            // 
            this.RemoteCurrentMedia.Location = new System.Drawing.Point(686, 42);
            this.RemoteCurrentMedia.Name = "RemoteCurrentMedia";
            this.RemoteCurrentMedia.Size = new System.Drawing.Size(168, 23);
            this.RemoteCurrentMedia.TabIndex = 38;
            this.RemoteCurrentMedia.Text = "現在のメディアを削除する";
            this.RemoteCurrentMedia.UseVisualStyleBackColor = true;
            this.RemoteCurrentMedia.Click += new System.EventHandler(this.button13_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 638);
            this.Controls.Add(this.RemoteCurrentMedia);
            this.Controls.Add(this.AddNextMedia);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.url);
            this.Controls.Add(this.name);
            this.Controls.Add(this.status);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Fast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.Slow);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.OpenMediaPlayer);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.CloseButton);
            this.Name = "Form1";
            this.Text = "Video/MusicPlayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox checkBox3;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button OpenMediaPlayer;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Slow;
        private System.Windows.Forms.TrackBar Volume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Fast;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label url;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox speed;
        private System.Windows.Forms.Button AddNextMedia;
        private System.Windows.Forms.Button RemoteCurrentMedia;
    }
}

