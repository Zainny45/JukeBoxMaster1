using System;

namespace JukeBox
{
    partial class Jukebox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jukebox));
            this.label1 = new System.Windows.Forms.Label();
            this.Playlist = new System.Windows.Forms.ListBox();
            this.playingNow = new System.Windows.Forms.TextBox();
            this.SelectGenre = new System.Windows.Forms.HScrollBar();
            this.GenreName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Genrelist = new System.Windows.Forms.ListBox();
            this.ChooseGenre = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(392, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright @ 2018 Zain Islam";
            // 
            // Playlist
            // 
            this.Playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Playlist.FormattingEnabled = true;
            this.Playlist.ItemHeight = 16;
            this.Playlist.Location = new System.Drawing.Point(196, 385);
            this.Playlist.Name = "Playlist";
            this.Playlist.Size = new System.Drawing.Size(217, 132);
            this.Playlist.TabIndex = 1;
            // 
            // playingNow
            // 
            this.playingNow.BackColor = System.Drawing.Color.Lime;
            this.playingNow.Location = new System.Drawing.Point(183, 351);
            this.playingNow.Name = "playingNow";
            this.playingNow.ReadOnly = true;
            this.playingNow.Size = new System.Drawing.Size(243, 22);
            this.playingNow.TabIndex = 2;
            // 
            // SelectGenre
            // 
            this.SelectGenre.Location = new System.Drawing.Point(183, 302);
            this.SelectGenre.Name = "SelectGenre";
            this.SelectGenre.Size = new System.Drawing.Size(243, 25);
            this.SelectGenre.TabIndex = 3;
            // 
            // GenreName
            // 
            this.GenreName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GenreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreName.Location = new System.Drawing.Point(183, 219);
            this.GenreName.Name = "GenreName";
            this.GenreName.ReadOnly = true;
            this.GenreName.Size = new System.Drawing.Size(243, 22);
            this.GenreName.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 754);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Setup";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(2, 749);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(623, 34);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(96, 754);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "About";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(148, 131);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(318, 46);
            this.MediaPlayer.TabIndex = 10;
            this.MediaPlayer.Visible = false;
            this.MediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.MediaPlayer_PlayStateChange);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Genrelist
            // 
            this.Genrelist.FormattingEnabled = true;
            this.Genrelist.ItemHeight = 16;
            this.Genrelist.Location = new System.Drawing.Point(183, 243);
            this.Genrelist.Name = "Genrelist";
            this.Genrelist.Size = new System.Drawing.Size(243, 84);
            this.Genrelist.TabIndex = 11;
            this.Genrelist.SelectedIndexChanged += new System.EventHandler(this.Genrelist_SelectedIndexChanged);
            this.Genrelist.DoubleClick += new System.EventHandler(this.Genrelist_DoubleClick);
            // 
            // ChooseGenre
            // 
            this.ChooseGenre.LargeChange = 20;
            this.ChooseGenre.Location = new System.Drawing.Point(183, 327);
            this.ChooseGenre.Maximum = 50;
            this.ChooseGenre.Name = "ChooseGenre";
            this.ChooseGenre.Size = new System.Drawing.Size(243, 21);
            this.ChooseGenre.TabIndex = 12;
            this.ChooseGenre.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ChooseGenre_Scroll);
            // 
            // Jukebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 784);
            this.Controls.Add(this.ChooseGenre);
            this.Controls.Add(this.Genrelist);
            this.Controls.Add(this.MediaPlayer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GenreName);
            this.Controls.Add(this.SelectGenre);
            this.Controls.Add(this.playingNow);
            this.Controls.Add(this.Playlist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Jukebox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Juke Box v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Playlist;
        private System.Windows.Forms.TextBox playingNow;
        private System.Windows.Forms.HScrollBar SelectGenre;
       
        private System.Windows.Forms.TextBox GenreName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox Genrelist;
        private System.Windows.Forms.HScrollBar ChooseGenre;
    }
}

