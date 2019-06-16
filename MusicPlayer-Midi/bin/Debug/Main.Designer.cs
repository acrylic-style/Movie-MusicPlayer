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
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.Volume = new System.Windows.Forms.TrackBar();
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(579, 141);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(562, 19);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(440, 19);
            this.textBox2.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(455, 160);
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
            this.checkBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBox3.Location = new System.Drawing.Point(494, 11);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(68, 16);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "Topmost";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // player
            // 
            this.player.AllowDrop = true;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(828, 50);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(21, 34);
            this.player.TabIndex = 12;
            this.player.Visible = false;
            this.player.Enter += new System.EventHandler(this.player_Enter);
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(690, 43);
            this.Volume.Maximum = 100;
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(168, 45);
            this.Volume.TabIndex = 19;
            this.Volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Volume.Value = 100;
            this.Volume.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.ForeColor = System.Drawing.SystemColors.Window;
            this.status.Location = new System.Drawing.Point(3, 32);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(44, 12);
            this.status.TabIndex = 25;
            this.status.Text = "Status: ";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.ForeColor = System.Drawing.SystemColors.Window;
            this.name.Location = new System.Drawing.Point(7, 54);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(40, 12);
            this.name.TabIndex = 26;
            this.name.Text = "Name: ";
            // 
            // url
            // 
            this.url.AutoSize = true;
            this.url.ForeColor = System.Drawing.SystemColors.Window;
            this.url.Location = new System.Drawing.Point(14, 77);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(29, 12);
            this.url.TabIndex = 27;
            this.url.Text = "URL:";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(56, 90);
            this.trackBar2.Maximum = 4;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(800, 45);
            this.trackBar2.TabIndex = 28;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(587, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 12);
            this.label2.TabIndex = 29;
            this.label2.Text = "1.5x Speed↑";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(388, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 12);
            this.label3.TabIndex = 30;
            this.label3.Text = "1.25x Speed↑";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(210, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 12);
            this.label4.TabIndex = 31;
            this.label4.Text = "1x Speed↑";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(63, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 12);
            this.label5.TabIndex = 32;
            this.label5.Text = "↑0.75x Speed";
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
            this.AddNextMedia.Location = new System.Drawing.Point(320, 8);
            this.AddNextMedia.Name = "AddNextMedia";
            this.AddNextMedia.Size = new System.Drawing.Size(168, 21);
            this.AddNextMedia.TabIndex = 37;
            this.AddNextMedia.Text = "Add Next Media";
            this.AddNextMedia.UseVisualStyleBackColor = true;
            this.AddNextMedia.Click += new System.EventHandler(this.button_13);
            // 
            // RemoteCurrentMedia
            // 
            this.RemoteCurrentMedia.Location = new System.Drawing.Point(146, 6);
            this.RemoteCurrentMedia.Name = "RemoteCurrentMedia";
            this.RemoteCurrentMedia.Size = new System.Drawing.Size(168, 23);
            this.RemoteCurrentMedia.TabIndex = 38;
            this.RemoteCurrentMedia.Text = "Remove Current Media";
            this.RemoteCurrentMedia.UseVisualStyleBackColor = true;
            this.RemoteCurrentMedia.Click += new System.EventHandler(this.button13_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 21);
            this.button1.TabIndex = 39;
            this.button1.Text = "Add all .mp3 files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(790, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 40;
            this.label1.Text = "2x Speed↑";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 44;
            this.button2.Text = "Remove all queues";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Volume);
            this.panel1.Location = new System.Drawing.Point(-4, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 101);
            this.panel1.TabIndex = 46;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Movie_MusicPlayer.Properties.Resources.volume_high;
            this.pictureBox5.Location = new System.Drawing.Point(658, 34);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 47;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Movie_MusicPlayer.Properties.Resources.fast_rewind;
            this.pictureBox7.Location = new System.Drawing.Point(216, 20);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(64, 64);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 50;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "False";
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Movie_MusicPlayer.Properties.Resources.fast_forward;
            this.pictureBox6.Location = new System.Drawing.Point(572, 20);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 64);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 49;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "False";
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::Movie_MusicPlayer.Properties.Resources.repeat;
            this.pictureBox4.Location = new System.Drawing.Point(534, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 48;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "False";
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Movie_MusicPlayer.Properties.Resources.skip_previous;
            this.pictureBox3.Location = new System.Drawing.Point(324, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 47;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Movie_MusicPlayer.Properties.Resources.skip_next;
            this.pictureBox2.Location = new System.Drawing.Point(464, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(394, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "play";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox8.Image = global::Movie_MusicPlayer.Properties.Resources.stop;
            this.pictureBox8.Location = new System.Drawing.Point(286, 20);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 51;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(684, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 12);
            this.label8.TabIndex = 47;
            this.label8.Text = "Ignore this, it\'s invisible->";
            this.label8.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(856, 287);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.player);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Video/MusicPlayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox checkBox3;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TrackBar Volume;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label8;
    }
}

