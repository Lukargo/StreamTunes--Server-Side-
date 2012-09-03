namespace StreamTunesServerSide
{
    partial class Form1
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
            this.ipTestButton = new System.Windows.Forms.Button();
            this.lbIP = new System.Windows.Forms.Label();
            this.getIPButton = new System.Windows.Forms.Button();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.File = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Song = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipTestButton
            // 
            this.ipTestButton.Location = new System.Drawing.Point(100, 75);
            this.ipTestButton.Name = "ipTestButton";
            this.ipTestButton.Size = new System.Drawing.Size(75, 23);
            this.ipTestButton.TabIndex = 0;
            this.ipTestButton.Text = "Update IP";
            this.ipTestButton.UseVisualStyleBackColor = true;
            this.ipTestButton.Click += new System.EventHandler(this.ipTestButton_Click);
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(119, 183);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(35, 13);
            this.lbIP.TabIndex = 1;
            this.lbIP.Text = "label1";
            // 
            // getIPButton
            // 
            this.getIPButton.Location = new System.Drawing.Point(100, 125);
            this.getIPButton.Name = "getIPButton";
            this.getIPButton.Size = new System.Drawing.Size(75, 23);
            this.getIPButton.TabIndex = 2;
            this.getIPButton.Text = "Get IP";
            this.getIPButton.UseVisualStyleBackColor = true;
            this.getIPButton.Click += new System.EventHandler(this.getIPButton_Click);
            // 
            // listViewFiles
            // 
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.File,
            this.Artist,
            this.Album,
            this.Song});
            this.listViewFiles.Location = new System.Drawing.Point(12, 247);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(653, 198);
            this.listViewFiles.TabIndex = 3;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            // 
            // File
            // 
            this.File.Text = "File";
            // 
            // Song
            // 
            this.Song.Text = "Song";
            // 
            // Artist
            // 
            this.Artist.Text = "Artist";
            // 
            // Album
            // 
            this.Album.Text = "Album";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Get Song Data!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewFiles);
            this.Controls.Add(this.getIPButton);
            this.Controls.Add(this.lbIP);
            this.Controls.Add(this.ipTestButton);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ipTestButton;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Button getIPButton;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.ColumnHeader File;
        private System.Windows.Forms.ColumnHeader Song;
        private System.Windows.Forms.ColumnHeader Artist;
        private System.Windows.Forms.ColumnHeader Album;
        private System.Windows.Forms.Button button1;
    }
}

