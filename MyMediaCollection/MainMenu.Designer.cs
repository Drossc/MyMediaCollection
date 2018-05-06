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
            this.SuspendLayout();
            // 
            // BtnBooks
            // 
            this.BtnBooks.BackColor = System.Drawing.Color.White;
            this.BtnBooks.Enabled = false;
            this.BtnBooks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBooks.FlatAppearance.BorderSize = 5;
            this.BtnBooks.Location = new System.Drawing.Point(12, 12);
            this.BtnBooks.Name = "BtnBooks";
            this.BtnBooks.Size = new System.Drawing.Size(150, 50);
            this.BtnBooks.TabIndex = 0;
            this.BtnBooks.Text = "Books";
            this.BtnBooks.UseMnemonic = false;
            this.BtnBooks.UseVisualStyleBackColor = false;
            this.BtnBooks.Click += new System.EventHandler(this.BtnBooks_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.White;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Location = new System.Drawing.Point(0, 364);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 28);
            this.statusStrip.TabIndex = 5;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnExit.FlatAppearance.BorderSize = 5;
            this.BtnExit.Location = new System.Drawing.Point(12, 236);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(150, 50);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseMnemonic = false;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnVideoGames
            // 
            this.BtnVideoGames.BackColor = System.Drawing.Color.White;
            this.BtnVideoGames.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnVideoGames.FlatAppearance.BorderSize = 5;
            this.BtnVideoGames.Location = new System.Drawing.Point(12, 180);
            this.BtnVideoGames.Name = "BtnVideoGames";
            this.BtnVideoGames.Size = new System.Drawing.Size(150, 50);
            this.BtnVideoGames.TabIndex = 3;
            this.BtnVideoGames.Text = "Video Games";
            this.BtnVideoGames.UseMnemonic = false;
            this.BtnVideoGames.UseVisualStyleBackColor = false;
            this.BtnVideoGames.Click += new System.EventHandler(this.BtnVideoGames_Click);
            // 
            // BtnCinema
            // 
            this.BtnCinema.BackColor = System.Drawing.Color.White;
            this.BtnCinema.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCinema.FlatAppearance.BorderSize = 5;
            this.BtnCinema.Location = new System.Drawing.Point(12, 68);
            this.BtnCinema.Name = "BtnCinema";
            this.BtnCinema.Size = new System.Drawing.Size(150, 50);
            this.BtnCinema.TabIndex = 1;
            this.BtnCinema.Text = "Cinema";
            this.BtnCinema.UseMnemonic = false;
            this.BtnCinema.UseVisualStyleBackColor = false;
            this.BtnCinema.Click += new System.EventHandler(this.BtnCinema_Click);
            // 
            // BtnMusic
            // 
            this.BtnMusic.BackColor = System.Drawing.Color.White;
            this.BtnMusic.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnMusic.FlatAppearance.BorderSize = 5;
            this.BtnMusic.Location = new System.Drawing.Point(12, 124);
            this.BtnMusic.Name = "BtnMusic";
            this.BtnMusic.Size = new System.Drawing.Size(150, 50);
            this.BtnMusic.TabIndex = 2;
            this.BtnMusic.Text = "Music";
            this.BtnMusic.UseMnemonic = false;
            this.BtnMusic.UseVisualStyleBackColor = false;
            this.BtnMusic.Click += new System.EventHandler(this.BtnMusic_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 392);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnVideoGames);
            this.Controls.Add(this.BtnCinema);
            this.Controls.Add(this.BtnMusic);
            this.Controls.Add(this.BtnBooks);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
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
    }
}

