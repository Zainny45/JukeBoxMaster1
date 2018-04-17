namespace JukeBox
{
    partial class Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Import_Tracks = new System.Windows.Forms.Button();
            this.Imported_tracks = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TrackList = new System.Windows.Forms.ListBox();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_Import_Tracks);
            this.groupBox1.Controls.Add(this.Imported_tracks);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imported Tracks";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear Import Tracks";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Import_Tracks
            // 
            this.btn_Import_Tracks.Location = new System.Drawing.Point(7, 320);
            this.btn_Import_Tracks.Name = "btn_Import_Tracks";
            this.btn_Import_Tracks.Size = new System.Drawing.Size(244, 27);
            this.btn_Import_Tracks.TabIndex = 1;
            this.btn_Import_Tracks.Text = "Import Tracks from Directory";
            this.btn_Import_Tracks.UseVisualStyleBackColor = true;
            this.btn_Import_Tracks.Click += new System.EventHandler(this.button1_Click);
            // 
            // Imported_tracks
            // 
            this.Imported_tracks.FormattingEnabled = true;
            this.Imported_tracks.ItemHeight = 16;
            this.Imported_tracks.Location = new System.Drawing.Point(7, 22);
            this.Imported_tracks.Name = "Imported_tracks";
            this.Imported_tracks.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Imported_tracks.Size = new System.Drawing.Size(244, 292);
            this.Imported_tracks.TabIndex = 0;
            this.Imported_tracks.SelectedIndexChanged += new System.EventHandler(this.Imported_tracks_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.nextButton);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.TrackList);
            this.groupBox2.Controls.Add(this.genreBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(439, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 407);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Present Genre ";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(85, 378);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(62, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(85, 336);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(153, 336);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(72, 65);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Next >>";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 65);
            this.button3.TabIndex = 3;
            this.button3.Text = "<< Previous";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TrackList
            // 
            this.TrackList.FormattingEnabled = true;
            this.TrackList.ItemHeight = 16;
            this.TrackList.Location = new System.Drawing.Point(10, 71);
            this.TrackList.Name = "TrackList";
            this.TrackList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.TrackList.Size = new System.Drawing.Size(215, 244);
            this.TrackList.TabIndex = 2;
            this.TrackList.SelectedIndexChanged += new System.EventHandler(this.TrackList_SelectedIndexChanged);
            // 
            // genreBox
            // 
            this.genreBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.genreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreBox.Location = new System.Drawing.Point(10, 43);
            this.genreBox.Name = "genreBox";
            this.genreBox.ReadOnly = true;
            this.genreBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.genreBox.Size = new System.Drawing.Size(215, 22);
            this.genreBox.TabIndex = 1;
            this.genreBox.Text = "OST";
            this.genreBox.TextChanged += new System.EventHandler(this.genreBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genre Title";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(287, 98);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(146, 30);
            this.button7.TabIndex = 2;
            this.button7.Text = "Copy Track >>";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(287, 146);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(146, 30);
            this.button8.TabIndex = 3;
            this.button8.Text = "Move Track >>";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(287, 247);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(146, 94);
            this.button9.TabIndex = 4;
            this.button9.Text = "Delete Track\r\nFrom\r\n Genre";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(508, 440);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 5;
            this.button10.Text = "Ok";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(589, 440);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 6;
            this.button11.Text = "Cancel";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 475);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Setup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Import_Tracks;
        private System.Windows.Forms.ListBox Imported_tracks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox TrackList;
        private System.Windows.Forms.TextBox genreBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}