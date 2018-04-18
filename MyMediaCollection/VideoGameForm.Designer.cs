﻿namespace MyMediaCollection
{
    partial class VideoGameForm
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
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblUPC = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblReleaseDate = new System.Windows.Forms.Label();
            this.LblPlatform = new System.Windows.Forms.Label();
            this.LblPurchDate = new System.Windows.Forms.Label();
            this.LblPurchAmt = new System.Windows.Forms.Label();
            this.LblPurchLoc = new System.Windows.Forms.Label();
            this.LblRetailAmt = new System.Windows.Forms.Label();
            this.LblDiscount = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LblSearch = new System.Windows.Forms.Label();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.TbTitle = new System.Windows.Forms.TextBox();
            this.TbUPC = new System.Windows.Forms.TextBox();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.TbReleaseDate = new System.Windows.Forms.TextBox();
            this.TbPlatform = new System.Windows.Forms.TextBox();
            this.TbPurchDate = new System.Windows.Forms.TextBox();
            this.TbPurchAmt = new System.Windows.Forms.TextBox();
            this.TbPurchLoc = new System.Windows.Forms.TextBox();
            this.TbRetailAmt = new System.Windows.Forms.TextBox();
            this.TbDiscount = new System.Windows.Forms.TextBox();
            this.tSSLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.White;
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSLable});
            this.StatusStrip.Location = new System.Drawing.Point(0, 416);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(801, 28);
            this.StatusStrip.TabIndex = 0;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(12, 56);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(42, 20);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Title:";
            // 
            // LblUPC
            // 
            this.LblUPC.AutoSize = true;
            this.LblUPC.Location = new System.Drawing.Point(12, 88);
            this.LblUPC.Name = "LblUPC";
            this.LblUPC.Size = new System.Drawing.Size(46, 20);
            this.LblUPC.TabIndex = 2;
            this.LblUPC.Text = "UPC:";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(12, 120);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(93, 20);
            this.LblDescription.TabIndex = 3;
            this.LblDescription.Text = "Description:";
            // 
            // LblReleaseDate
            // 
            this.LblReleaseDate.AutoSize = true;
            this.LblReleaseDate.Location = new System.Drawing.Point(12, 152);
            this.LblReleaseDate.Name = "LblReleaseDate";
            this.LblReleaseDate.Size = new System.Drawing.Size(111, 20);
            this.LblReleaseDate.TabIndex = 4;
            this.LblReleaseDate.Text = "Release Date:";
            // 
            // LblPlatform
            // 
            this.LblPlatform.AutoSize = true;
            this.LblPlatform.Location = new System.Drawing.Point(12, 184);
            this.LblPlatform.Name = "LblPlatform";
            this.LblPlatform.Size = new System.Drawing.Size(72, 20);
            this.LblPlatform.TabIndex = 5;
            this.LblPlatform.Text = "Platform:";
            // 
            // LblPurchDate
            // 
            this.LblPurchDate.AutoSize = true;
            this.LblPurchDate.Location = new System.Drawing.Point(12, 216);
            this.LblPurchDate.Name = "LblPurchDate";
            this.LblPurchDate.Size = new System.Drawing.Size(119, 20);
            this.LblPurchDate.TabIndex = 6;
            this.LblPurchDate.Text = "Purchase Date:";
            // 
            // LblPurchAmt
            // 
            this.LblPurchAmt.AutoSize = true;
            this.LblPurchAmt.Location = new System.Drawing.Point(12, 248);
            this.LblPurchAmt.Name = "LblPurchAmt";
            this.LblPurchAmt.Size = new System.Drawing.Size(140, 20);
            this.LblPurchAmt.TabIndex = 7;
            this.LblPurchAmt.Text = "Purchase Amount:";
            // 
            // LblPurchLoc
            // 
            this.LblPurchLoc.AutoSize = true;
            this.LblPurchLoc.Location = new System.Drawing.Point(12, 280);
            this.LblPurchLoc.Name = "LblPurchLoc";
            this.LblPurchLoc.Size = new System.Drawing.Size(145, 20);
            this.LblPurchLoc.TabIndex = 8;
            this.LblPurchLoc.Text = "Purchase Location:";
            // 
            // LblRetailAmt
            // 
            this.LblRetailAmt.AutoSize = true;
            this.LblRetailAmt.Location = new System.Drawing.Point(12, 312);
            this.LblRetailAmt.Name = "LblRetailAmt";
            this.LblRetailAmt.Size = new System.Drawing.Size(114, 20);
            this.LblRetailAmt.TabIndex = 9;
            this.LblRetailAmt.Text = "Retail Amount:";
            // 
            // LblDiscount
            // 
            this.LblDiscount.AutoSize = true;
            this.LblDiscount.Location = new System.Drawing.Point(12, 344);
            this.LblDiscount.Name = "LblDiscount";
            this.LblDiscount.Size = new System.Drawing.Size(76, 20);
            this.LblDiscount.TabIndex = 10;
            this.LblDiscount.Text = "Discount:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(637, 64);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(150, 50);
            this.BtnAdd.TabIndex = 11;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(637, 360);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(150, 50);
            this.BtnExit.TabIndex = 12;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.Color.White;
            this.BtnRemove.Location = new System.Drawing.Point(637, 120);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(150, 50);
            this.BtnRemove.TabIndex = 13;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.White;
            this.BtnSearch.Location = new System.Drawing.Point(637, 8);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(150, 50);
            this.BtnSearch.TabIndex = 0;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Location = new System.Drawing.Point(12, 23);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(97, 20);
            this.LblSearch.TabIndex = 15;
            this.LblSearch.Text = "Enter Value:";
            // 
            // TbSearch
            // 
            this.TbSearch.Location = new System.Drawing.Point(115, 20);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(516, 26);
            this.TbSearch.TabIndex = 16;
            // 
            // TbTitle
            // 
            this.TbTitle.Location = new System.Drawing.Point(157, 53);
            this.TbTitle.Name = "TbTitle";
            this.TbTitle.Size = new System.Drawing.Size(474, 26);
            this.TbTitle.TabIndex = 17;
            // 
            // TbUPC
            // 
            this.TbUPC.Location = new System.Drawing.Point(157, 85);
            this.TbUPC.Name = "TbUPC";
            this.TbUPC.Size = new System.Drawing.Size(474, 26);
            this.TbUPC.TabIndex = 18;
            // 
            // TbDescription
            // 
            this.TbDescription.Location = new System.Drawing.Point(157, 117);
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(474, 26);
            this.TbDescription.TabIndex = 19;
            // 
            // TbReleaseDate
            // 
            this.TbReleaseDate.Location = new System.Drawing.Point(157, 149);
            this.TbReleaseDate.Name = "TbReleaseDate";
            this.TbReleaseDate.Size = new System.Drawing.Size(474, 26);
            this.TbReleaseDate.TabIndex = 20;
            // 
            // TbPlatform
            // 
            this.TbPlatform.Location = new System.Drawing.Point(157, 181);
            this.TbPlatform.Name = "TbPlatform";
            this.TbPlatform.Size = new System.Drawing.Size(474, 26);
            this.TbPlatform.TabIndex = 21;
            // 
            // TbPurchDate
            // 
            this.TbPurchDate.Location = new System.Drawing.Point(157, 213);
            this.TbPurchDate.Name = "TbPurchDate";
            this.TbPurchDate.Size = new System.Drawing.Size(474, 26);
            this.TbPurchDate.TabIndex = 22;
            // 
            // TbPurchAmt
            // 
            this.TbPurchAmt.Location = new System.Drawing.Point(157, 245);
            this.TbPurchAmt.Name = "TbPurchAmt";
            this.TbPurchAmt.Size = new System.Drawing.Size(474, 26);
            this.TbPurchAmt.TabIndex = 23;
            // 
            // TbPurchLoc
            // 
            this.TbPurchLoc.Location = new System.Drawing.Point(157, 277);
            this.TbPurchLoc.Name = "TbPurchLoc";
            this.TbPurchLoc.Size = new System.Drawing.Size(474, 26);
            this.TbPurchLoc.TabIndex = 24;
            // 
            // TbRetailAmt
            // 
            this.TbRetailAmt.Location = new System.Drawing.Point(157, 309);
            this.TbRetailAmt.Name = "TbRetailAmt";
            this.TbRetailAmt.Size = new System.Drawing.Size(474, 26);
            this.TbRetailAmt.TabIndex = 25;
            // 
            // TbDiscount
            // 
            this.TbDiscount.Location = new System.Drawing.Point(157, 341);
            this.TbDiscount.Name = "TbDiscount";
            this.TbDiscount.Size = new System.Drawing.Size(474, 26);
            this.TbDiscount.TabIndex = 26;
            // 
            // tSSLable
            // 
            this.tSSLable.Name = "tSSLable";
            this.tSSLable.Size = new System.Drawing.Size(0, 23);
            // 
            // VideoGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(801, 444);
            this.Controls.Add(this.TbDiscount);
            this.Controls.Add(this.TbRetailAmt);
            this.Controls.Add(this.TbPurchLoc);
            this.Controls.Add(this.TbPurchAmt);
            this.Controls.Add(this.TbPurchDate);
            this.Controls.Add(this.TbPlatform);
            this.Controls.Add(this.TbReleaseDate);
            this.Controls.Add(this.TbDescription);
            this.Controls.Add(this.TbUPC);
            this.Controls.Add(this.TbTitle);
            this.Controls.Add(this.TbSearch);
            this.Controls.Add(this.LblSearch);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LblDiscount);
            this.Controls.Add(this.LblRetailAmt);
            this.Controls.Add(this.LblPurchLoc);
            this.Controls.Add(this.LblPurchAmt);
            this.Controls.Add(this.LblPurchDate);
            this.Controls.Add(this.LblPlatform);
            this.Controls.Add(this.LblReleaseDate);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblUPC);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.StatusStrip);
            this.Name = "VideoGameForm";
            this.Text = "Video Games";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblUPC;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblReleaseDate;
        private System.Windows.Forms.Label LblPlatform;
        private System.Windows.Forms.Label LblPurchDate;
        private System.Windows.Forms.Label LblPurchAmt;
        private System.Windows.Forms.Label LblPurchLoc;
        private System.Windows.Forms.Label LblRetailAmt;
        private System.Windows.Forms.Label LblDiscount;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.TextBox TbSearch;
        private System.Windows.Forms.TextBox TbTitle;
        private System.Windows.Forms.TextBox TbUPC;
        private System.Windows.Forms.TextBox TbDescription;
        private System.Windows.Forms.TextBox TbReleaseDate;
        private System.Windows.Forms.TextBox TbPlatform;
        private System.Windows.Forms.TextBox TbPurchDate;
        private System.Windows.Forms.TextBox TbPurchAmt;
        private System.Windows.Forms.TextBox TbPurchLoc;
        private System.Windows.Forms.TextBox TbRetailAmt;
        private System.Windows.Forms.TextBox TbDiscount;
        private System.Windows.Forms.ToolStripStatusLabel tSSLable;
    }
}