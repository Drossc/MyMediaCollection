namespace MyMediaCollection
{
    partial class MainMenuForm
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
            this.BtnBooks = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnVideoGames = new System.Windows.Forms.Button();
            this.BtnCinema = new System.Windows.Forms.Button();
            this.BtnMusic = new System.Windows.Forms.Button();
            this.CmbAppUser = new System.Windows.Forms.ComboBox();
            this.LblAppUser = new System.Windows.Forms.Label();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.BtnRemoveUser = new System.Windows.Forms.Button();
            this.tssLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBooks
            // 
            this.BtnBooks.BackColor = System.Drawing.Color.White;
            this.BtnBooks.Enabled = false;
            this.BtnBooks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBooks.FlatAppearance.BorderSize = 5;
            this.BtnBooks.Location = new System.Drawing.Point(65, 83);
            this.BtnBooks.Name = "BtnBooks";
            this.BtnBooks.Size = new System.Drawing.Size(150, 50);
            this.BtnBooks.TabIndex = 3;
            this.BtnBooks.Text = "Books";
            this.BtnBooks.UseMnemonic = false;
            this.BtnBooks.UseVisualStyleBackColor = false;
            this.BtnBooks.Click += new System.EventHandler(this.BtnBooks_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.White;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 497);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(283, 28);
            this.statusStrip.TabIndex = 5;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnExit.FlatAppearance.BorderSize = 5;
            this.BtnExit.Location = new System.Drawing.Point(65, 369);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(150, 50);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseMnemonic = false;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnVideoGames
            // 
            this.BtnVideoGames.BackColor = System.Drawing.Color.White;
            this.BtnVideoGames.Enabled = false;
            this.BtnVideoGames.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnVideoGames.FlatAppearance.BorderSize = 5;
            this.BtnVideoGames.Location = new System.Drawing.Point(65, 251);
            this.BtnVideoGames.Name = "BtnVideoGames";
            this.BtnVideoGames.Size = new System.Drawing.Size(150, 50);
            this.BtnVideoGames.TabIndex = 6;
            this.BtnVideoGames.Text = "Video Games";
            this.BtnVideoGames.UseMnemonic = false;
            this.BtnVideoGames.UseVisualStyleBackColor = false;
            this.BtnVideoGames.Click += new System.EventHandler(this.BtnVideoGames_Click);
            // 
            // BtnCinema
            // 
            this.BtnCinema.BackColor = System.Drawing.Color.White;
            this.BtnCinema.Enabled = false;
            this.BtnCinema.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCinema.FlatAppearance.BorderSize = 5;
            this.BtnCinema.Location = new System.Drawing.Point(65, 139);
            this.BtnCinema.Name = "BtnCinema";
            this.BtnCinema.Size = new System.Drawing.Size(150, 50);
            this.BtnCinema.TabIndex = 4;
            this.BtnCinema.Text = "Cinema";
            this.BtnCinema.UseMnemonic = false;
            this.BtnCinema.UseVisualStyleBackColor = false;
            this.BtnCinema.Click += new System.EventHandler(this.BtnCinema_Click);
            // 
            // BtnMusic
            // 
            this.BtnMusic.BackColor = System.Drawing.Color.White;
            this.BtnMusic.Enabled = false;
            this.BtnMusic.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnMusic.FlatAppearance.BorderSize = 5;
            this.BtnMusic.Location = new System.Drawing.Point(65, 195);
            this.BtnMusic.Name = "BtnMusic";
            this.BtnMusic.Size = new System.Drawing.Size(150, 50);
            this.BtnMusic.TabIndex = 5;
            this.BtnMusic.Text = "Music";
            this.BtnMusic.UseMnemonic = false;
            this.BtnMusic.UseVisualStyleBackColor = false;
            this.BtnMusic.Click += new System.EventHandler(this.BtnMusic_Click);
            // 
            // CmbAppUser
            // 
            this.CmbAppUser.FormattingEnabled = true;
            this.CmbAppUser.Items.AddRange(new object[] {
            "Johnny B Good",
            "Jenny B Bad",
            "Jimmy D John",
            "Benny B There"});
            this.CmbAppUser.Location = new System.Drawing.Point(39, 37);
            this.CmbAppUser.Name = "CmbAppUser";
            this.CmbAppUser.Size = new System.Drawing.Size(200, 28);
            this.CmbAppUser.TabIndex = 0;
            this.CmbAppUser.TextChanged += new System.EventHandler(this.CmbAppUser_TextChanged);
            // 
            // LblAppUser
            // 
            this.LblAppUser.AutoSize = true;
            this.LblAppUser.Location = new System.Drawing.Point(78, 14);
            this.LblAppUser.Name = "LblAppUser";
            this.LblAppUser.Size = new System.Drawing.Size(121, 20);
            this.LblAppUser.TabIndex = 7;
            this.LblAppUser.Text = "Collector Name:";
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Location = new System.Drawing.Point(245, 23);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(26, 28);
            this.BtnAddUser.TabIndex = 1;
            this.BtnAddUser.TabStop = false;
            this.BtnAddUser.Text = "+";
            this.BtnAddUser.UseMnemonic = false;
            this.BtnAddUser.UseVisualStyleBackColor = false;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // BtnRemoveUser
            // 
            this.BtnRemoveUser.Location = new System.Drawing.Point(245, 51);
            this.BtnRemoveUser.Name = "BtnRemoveUser";
            this.BtnRemoveUser.Size = new System.Drawing.Size(26, 28);
            this.BtnRemoveUser.TabIndex = 2;
            this.BtnRemoveUser.TabStop = false;
            this.BtnRemoveUser.Text = "-";
            this.BtnRemoveUser.UseMnemonic = false;
            this.BtnRemoveUser.UseVisualStyleBackColor = false;
            this.BtnRemoveUser.Click += new System.EventHandler(this.BtnRemoveUser_Click);
            // 
            // tssLabel
            // 
            this.tssLabel.Name = "tssLabel";
            this.tssLabel.Size = new System.Drawing.Size(0, 23);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(283, 525);
            this.Controls.Add(this.BtnRemoveUser);
            this.Controls.Add(this.BtnAddUser);
            this.Controls.Add(this.LblAppUser);
            this.Controls.Add(this.CmbAppUser);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnVideoGames);
            this.Controls.Add(this.BtnCinema);
            this.Controls.Add(this.BtnMusic);
            this.Controls.Add(this.BtnBooks);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBooks;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnVideoGames;
        private System.Windows.Forms.Button BtnCinema;
        private System.Windows.Forms.Button BtnMusic;
        private System.Windows.Forms.ComboBox CmbAppUser;
        private System.Windows.Forms.Label LblAppUser;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.Button BtnRemoveUser;
        private System.Windows.Forms.ToolStripStatusLabel tssLabel;
    }
}

