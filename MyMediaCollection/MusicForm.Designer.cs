﻿namespace MyMediaCollection
{
    partial class MusicForm
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
            this.CbVinyl = new System.Windows.Forms.CheckBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.tSSLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.CmbPurchLoc = new System.Windows.Forms.ComboBox();
            this.CbCassette = new System.Windows.Forms.CheckBox();
            this.TbUPC = new System.Windows.Forms.TextBox();
            this.GbPurchases = new System.Windows.Forms.GroupBox();
            this.LblUPC = new System.Windows.Forms.Label();
            this.CbCD = new System.Windows.Forms.CheckBox();
            this.MtbPurchAmt = new System.Windows.Forms.MaskedTextBox();
            this.LblPurchDate = new System.Windows.Forms.Label();
            this.CbDigital = new System.Windows.Forms.CheckBox();
            this.TbDiscount = new System.Windows.Forms.TextBox();
            this.DtpPurchDate = new System.Windows.Forms.DateTimePicker();
            this.LblPurchAmt = new System.Windows.Forms.Label();
            this.LblPurchLoc = new System.Windows.Forms.Label();
            this.LblDiscount = new System.Windows.Forms.Label();
            this.LblRetailAmt = new System.Windows.Forms.Label();
            this.GbSearch = new System.Windows.Forms.GroupBox();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LlRatings = new System.Windows.Forms.LinkLabel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.GbGenDetails = new System.Windows.Forms.GroupBox();
            this.TbTitle = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.MtbRetailAmt = new System.Windows.Forms.MaskedTextBox();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.DtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.LblReleaseDate = new System.Windows.Forms.Label();
            this.CbExplicit = new System.Windows.Forms.CheckBox();
            this.StatusStrip.SuspendLayout();
            this.GbPurchases.SuspendLayout();
            this.GbSearch.SuspendLayout();
            this.GbGenDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbVinyl
            // 
            this.CbVinyl.AutoSize = true;
            this.CbVinyl.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CbVinyl.Location = new System.Drawing.Point(111, 25);
            this.CbVinyl.Name = "CbVinyl";
            this.CbVinyl.Size = new System.Drawing.Size(46, 45);
            this.CbVinyl.TabIndex = 17;
            this.CbVinyl.Text = "Vinyl";
            this.CbVinyl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CbVinyl.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(714, 25);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(150, 50);
            this.BtnAdd.TabIndex = 21;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(714, 225);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(150, 50);
            this.BtnExit.TabIndex = 25;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.Color.White;
            this.BtnRemove.Enabled = false;
            this.BtnRemove.Location = new System.Drawing.Point(714, 125);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(150, 50);
            this.BtnRemove.TabIndex = 23;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = false;
            // 
            // tSSLable
            // 
            this.tSSLable.Name = "tSSLable";
            this.tSSLable.Size = new System.Drawing.Size(0, 17);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(714, 175);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(150, 50);
            this.BtnClear.TabIndex = 24;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.White;
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Location = new System.Drawing.Point(714, 75);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(150, 50);
            this.BtnUpdate.TabIndex = 22;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.White;
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSLable});
            this.StatusStrip.Location = new System.Drawing.Point(0, 446);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(901, 22);
            this.StatusStrip.TabIndex = 18;
            // 
            // CmbPurchLoc
            // 
            this.CmbPurchLoc.FormattingEnabled = true;
            this.CmbPurchLoc.Items.AddRange(new object[] {
            "Amazon",
            "Best Buy",
            "Garage Sale",
            "Google Music",
            "iTunes",
            "Target",
            "Toys-R-Us",
            "Wal-Mart"});
            this.CmbPurchLoc.Location = new System.Drawing.Point(473, 47);
            this.CmbPurchLoc.Name = "CmbPurchLoc";
            this.CmbPurchLoc.Size = new System.Drawing.Size(150, 28);
            this.CmbPurchLoc.TabIndex = 11;
            this.CmbPurchLoc.Text = "Amazon";
            // 
            // CbCassette
            // 
            this.CbCassette.AutoSize = true;
            this.CbCassette.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CbCassette.Location = new System.Drawing.Point(163, 25);
            this.CbCassette.Name = "CbCassette";
            this.CbCassette.Size = new System.Drawing.Size(77, 45);
            this.CbCassette.TabIndex = 15;
            this.CbCassette.Text = "Cassette";
            this.CbCassette.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CbCassette.UseVisualStyleBackColor = true;
            // 
            // TbUPC
            // 
            this.TbUPC.Location = new System.Drawing.Point(707, 47);
            this.TbUPC.Name = "TbUPC";
            this.TbUPC.Size = new System.Drawing.Size(128, 26);
            this.TbUPC.TabIndex = 8;
            this.TbUPC.Text = "883929319572";
            // 
            // GbPurchases
            // 
            this.GbPurchases.Controls.Add(this.CbVinyl);
            this.GbPurchases.Controls.Add(this.CmbPurchLoc);
            this.GbPurchases.Controls.Add(this.CbCassette);
            this.GbPurchases.Controls.Add(this.TbUPC);
            this.GbPurchases.Controls.Add(this.LblUPC);
            this.GbPurchases.Controls.Add(this.CbCD);
            this.GbPurchases.Controls.Add(this.MtbPurchAmt);
            this.GbPurchases.Controls.Add(this.LblPurchDate);
            this.GbPurchases.Controls.Add(this.CbDigital);
            this.GbPurchases.Controls.Add(this.TbDiscount);
            this.GbPurchases.Controls.Add(this.DtpPurchDate);
            this.GbPurchases.Controls.Add(this.LblPurchAmt);
            this.GbPurchases.Controls.Add(this.LblPurchLoc);
            this.GbPurchases.Controls.Add(this.LblDiscount);
            this.GbPurchases.Location = new System.Drawing.Point(12, 318);
            this.GbPurchases.Name = "GbPurchases";
            this.GbPurchases.Size = new System.Drawing.Size(852, 95);
            this.GbPurchases.TabIndex = 20;
            this.GbPurchases.TabStop = false;
            this.GbPurchases.Text = "Purchases";
            // 
            // LblUPC
            // 
            this.LblUPC.AutoSize = true;
            this.LblUPC.Location = new System.Drawing.Point(707, 26);
            this.LblUPC.Name = "LblUPC";
            this.LblUPC.Size = new System.Drawing.Size(46, 20);
            this.LblUPC.TabIndex = 2;
            this.LblUPC.Text = "UPC:";
            // 
            // CbCD
            // 
            this.CbCD.AutoSize = true;
            this.CbCD.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CbCD.Location = new System.Drawing.Point(69, 25);
            this.CbCD.Name = "CbCD";
            this.CbCD.Size = new System.Drawing.Size(36, 45);
            this.CbCD.TabIndex = 14;
            this.CbCD.Text = "CD";
            this.CbCD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CbCD.UseVisualStyleBackColor = true;
            // 
            // MtbPurchAmt
            // 
            this.MtbPurchAmt.Location = new System.Drawing.Point(402, 47);
            this.MtbPurchAmt.Mask = "$99.00";
            this.MtbPurchAmt.Name = "MtbPurchAmt";
            this.MtbPurchAmt.Size = new System.Drawing.Size(65, 26);
            this.MtbPurchAmt.TabIndex = 10;
            this.MtbPurchAmt.Text = "1499";
            this.MtbPurchAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblPurchDate
            // 
            this.LblPurchDate.AutoSize = true;
            this.LblPurchDate.Location = new System.Drawing.Point(246, 26);
            this.LblPurchDate.Name = "LblPurchDate";
            this.LblPurchDate.Size = new System.Drawing.Size(48, 20);
            this.LblPurchDate.TabIndex = 6;
            this.LblPurchDate.Text = "Date:";
            // 
            // CbDigital
            // 
            this.CbDigital.AutoSize = true;
            this.CbDigital.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CbDigital.Location = new System.Drawing.Point(6, 25);
            this.CbDigital.Name = "CbDigital";
            this.CbDigital.Size = new System.Drawing.Size(57, 45);
            this.CbDigital.TabIndex = 13;
            this.CbDigital.Text = "Digital";
            this.CbDigital.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CbDigital.UseVisualStyleBackColor = true;
            // 
            // TbDiscount
            // 
            this.TbDiscount.Location = new System.Drawing.Point(629, 47);
            this.TbDiscount.Name = "TbDiscount";
            this.TbDiscount.Size = new System.Drawing.Size(72, 26);
            this.TbDiscount.TabIndex = 12;
            // 
            // DtpPurchDate
            // 
            this.DtpPurchDate.CustomFormat = "MM/dd/yyyy";
            this.DtpPurchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpPurchDate.Location = new System.Drawing.Point(246, 47);
            this.DtpPurchDate.Name = "DtpPurchDate";
            this.DtpPurchDate.Size = new System.Drawing.Size(150, 26);
            this.DtpPurchDate.TabIndex = 9;
            this.DtpPurchDate.Value = new System.DateTime(2015, 9, 30, 0, 0, 0, 0);
            // 
            // LblPurchAmt
            // 
            this.LblPurchAmt.AutoSize = true;
            this.LblPurchAmt.Location = new System.Drawing.Point(398, 26);
            this.LblPurchAmt.Name = "LblPurchAmt";
            this.LblPurchAmt.Size = new System.Drawing.Size(69, 20);
            this.LblPurchAmt.TabIndex = 7;
            this.LblPurchAmt.Text = "Amount:";
            // 
            // LblPurchLoc
            // 
            this.LblPurchLoc.AutoSize = true;
            this.LblPurchLoc.Location = new System.Drawing.Point(473, 26);
            this.LblPurchLoc.Name = "LblPurchLoc";
            this.LblPurchLoc.Size = new System.Drawing.Size(74, 20);
            this.LblPurchLoc.TabIndex = 8;
            this.LblPurchLoc.Text = "Location:";
            // 
            // LblDiscount
            // 
            this.LblDiscount.AutoSize = true;
            this.LblDiscount.Location = new System.Drawing.Point(625, 26);
            this.LblDiscount.Name = "LblDiscount";
            this.LblDiscount.Size = new System.Drawing.Size(76, 20);
            this.LblDiscount.TabIndex = 10;
            this.LblDiscount.Text = "Discount:";
            // 
            // LblRetailAmt
            // 
            this.LblRetailAmt.AutoSize = true;
            this.LblRetailAmt.Location = new System.Drawing.Point(523, 79);
            this.LblRetailAmt.Name = "LblRetailAmt";
            this.LblRetailAmt.Size = new System.Drawing.Size(114, 20);
            this.LblRetailAmt.TabIndex = 9;
            this.LblRetailAmt.Text = "Retail Amount:";
            // 
            // GbSearch
            // 
            this.GbSearch.Controls.Add(this.TbSearch);
            this.GbSearch.Controls.Add(this.BtnSearch);
            this.GbSearch.Location = new System.Drawing.Point(12, 6);
            this.GbSearch.Name = "GbSearch";
            this.GbSearch.Size = new System.Drawing.Size(673, 80);
            this.GbSearch.TabIndex = 17;
            this.GbSearch.TabStop = false;
            this.GbSearch.Text = "Search Album:";
            // 
            // TbSearch
            // 
            this.TbSearch.Location = new System.Drawing.Point(6, 32);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(474, 26);
            this.TbSearch.TabIndex = 0;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.White;
            this.BtnSearch.Enabled = false;
            this.BtnSearch.Location = new System.Drawing.Point(502, 20);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(150, 50);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            // 
            // LlRatings
            // 
            this.LlRatings.AutoSize = true;
            this.LlRatings.Location = new System.Drawing.Point(523, 136);
            this.LlRatings.Name = "LlRatings";
            this.LlRatings.Size = new System.Drawing.Size(86, 20);
            this.LlRatings.TabIndex = 6;
            this.LlRatings.TabStop = true;
            this.LlRatings.Text = "RIAA PAL:";
            this.LlRatings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlRatings_LinkClicked);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(2, 22);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(42, 20);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Title:";
            // 
            // GbGenDetails
            // 
            this.GbGenDetails.Controls.Add(this.CbExplicit);
            this.GbGenDetails.Controls.Add(this.LlRatings);
            this.GbGenDetails.Controls.Add(this.LblTitle);
            this.GbGenDetails.Controls.Add(this.TbTitle);
            this.GbGenDetails.Controls.Add(this.LblDescription);
            this.GbGenDetails.Controls.Add(this.MtbRetailAmt);
            this.GbGenDetails.Controls.Add(this.TbDescription);
            this.GbGenDetails.Controls.Add(this.DtpReleaseDate);
            this.GbGenDetails.Controls.Add(this.LblReleaseDate);
            this.GbGenDetails.Controls.Add(this.LblRetailAmt);
            this.GbGenDetails.Location = new System.Drawing.Point(12, 92);
            this.GbGenDetails.Name = "GbGenDetails";
            this.GbGenDetails.Size = new System.Drawing.Size(673, 217);
            this.GbGenDetails.TabIndex = 19;
            this.GbGenDetails.TabStop = false;
            this.GbGenDetails.Text = "General Details";
            // 
            // TbTitle
            // 
            this.TbTitle.Location = new System.Drawing.Point(6, 45);
            this.TbTitle.Name = "TbTitle";
            this.TbTitle.Size = new System.Drawing.Size(474, 26);
            this.TbTitle.TabIndex = 2;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(2, 74);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(93, 20);
            this.LblDescription.TabIndex = 3;
            this.LblDescription.Text = "Description:";
            // 
            // MtbRetailAmt
            // 
            this.MtbRetailAmt.Location = new System.Drawing.Point(527, 102);
            this.MtbRetailAmt.Mask = "$99.00";
            this.MtbRetailAmt.Name = "MtbRetailAmt";
            this.MtbRetailAmt.Size = new System.Drawing.Size(125, 26);
            this.MtbRetailAmt.TabIndex = 5;
            this.MtbRetailAmt.Text = "2999";
            this.MtbRetailAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TbDescription
            // 
            this.TbDescription.Location = new System.Drawing.Point(6, 99);
            this.TbDescription.Multiline = true;
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(474, 85);
            this.TbDescription.TabIndex = 3;
            // 
            // DtpReleaseDate
            // 
            this.DtpReleaseDate.CustomFormat = "MM/dd/yyyy";
            this.DtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpReleaseDate.Location = new System.Drawing.Point(527, 45);
            this.DtpReleaseDate.Name = "DtpReleaseDate";
            this.DtpReleaseDate.Size = new System.Drawing.Size(125, 26);
            this.DtpReleaseDate.TabIndex = 4;
            this.DtpReleaseDate.Value = new System.DateTime(2014, 9, 30, 0, 0, 0, 0);
            // 
            // LblReleaseDate
            // 
            this.LblReleaseDate.AutoSize = true;
            this.LblReleaseDate.Location = new System.Drawing.Point(523, 22);
            this.LblReleaseDate.Name = "LblReleaseDate";
            this.LblReleaseDate.Size = new System.Drawing.Size(111, 20);
            this.LblReleaseDate.TabIndex = 4;
            this.LblReleaseDate.Text = "Release Date:";
            // 
            // CbExplicit
            // 
            this.CbExplicit.AutoSize = true;
            this.CbExplicit.Location = new System.Drawing.Point(630, 134);
            this.CbExplicit.Name = "CbExplicit";
            this.CbExplicit.Size = new System.Drawing.Size(22, 21);
            this.CbExplicit.TabIndex = 10;
            this.CbExplicit.UseVisualStyleBackColor = true;
            // 
            // MusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 468);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.GbPurchases);
            this.Controls.Add(this.GbSearch);
            this.Controls.Add(this.GbGenDetails);
            this.Name = "MusicForm";
            this.Text = "Music";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.GbPurchases.ResumeLayout(false);
            this.GbPurchases.PerformLayout();
            this.GbSearch.ResumeLayout(false);
            this.GbSearch.PerformLayout();
            this.GbGenDetails.ResumeLayout(false);
            this.GbGenDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CbVinyl;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.ToolStripStatusLabel tSSLable;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ComboBox CmbPurchLoc;
        private System.Windows.Forms.CheckBox CbCassette;
        private System.Windows.Forms.TextBox TbUPC;
        private System.Windows.Forms.GroupBox GbPurchases;
        private System.Windows.Forms.Label LblUPC;
        private System.Windows.Forms.CheckBox CbCD;
        private System.Windows.Forms.MaskedTextBox MtbPurchAmt;
        private System.Windows.Forms.Label LblPurchDate;
        private System.Windows.Forms.CheckBox CbDigital;
        private System.Windows.Forms.TextBox TbDiscount;
        private System.Windows.Forms.DateTimePicker DtpPurchDate;
        private System.Windows.Forms.Label LblPurchAmt;
        private System.Windows.Forms.Label LblPurchLoc;
        private System.Windows.Forms.Label LblDiscount;
        private System.Windows.Forms.Label LblRetailAmt;
        private System.Windows.Forms.GroupBox GbSearch;
        private System.Windows.Forms.TextBox TbSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.LinkLabel LlRatings;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.GroupBox GbGenDetails;
        private System.Windows.Forms.TextBox TbTitle;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.MaskedTextBox MtbRetailAmt;
        private System.Windows.Forms.TextBox TbDescription;
        private System.Windows.Forms.DateTimePicker DtpReleaseDate;
        private System.Windows.Forms.Label LblReleaseDate;
        private System.Windows.Forms.CheckBox CbExplicit;
    }
}