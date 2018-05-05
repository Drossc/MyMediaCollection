namespace MyMediaCollection
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
            this.tSSLable = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.TbTitle = new System.Windows.Forms.TextBox();
            this.TbUPC = new System.Windows.Forms.TextBox();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.TbDiscount = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.DtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.DtpPurchDate = new System.Windows.Forms.DateTimePicker();
            this.MtbPurchAmt = new System.Windows.Forms.MaskedTextBox();
            this.MtbRetailAmt = new System.Windows.Forms.MaskedTextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.CmbPurchLoc = new System.Windows.Forms.ComboBox();
            this.CmbPlatform = new System.Windows.Forms.ComboBox();
            this.GbPurchases = new System.Windows.Forms.GroupBox();
            this.CbDigital = new System.Windows.Forms.CheckBox();
            this.GbGenDetails = new System.Windows.Forms.GroupBox();
            this.LlRatings = new System.Windows.Forms.LinkLabel();
            this.CmbRating = new System.Windows.Forms.ComboBox();
            this.GbSearch = new System.Windows.Forms.GroupBox();
            this.StatusStrip.SuspendLayout();
            this.GbPurchases.SuspendLayout();
            this.GbGenDetails.SuspendLayout();
            this.GbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.White;
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSLable});
            this.StatusStrip.Location = new System.Drawing.Point(0, 449);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(964, 22);
            this.StatusStrip.TabIndex = 0;
            // 
            // tSSLable
            // 
            this.tSSLable.Name = "tSSLable";
            this.tSSLable.Size = new System.Drawing.Size(0, 17);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(27, 22);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(42, 20);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Title:";
            // 
            // LblUPC
            // 
            this.LblUPC.AutoSize = true;
            this.LblUPC.Location = new System.Drawing.Point(265, 22);
            this.LblUPC.Name = "LblUPC";
            this.LblUPC.Size = new System.Drawing.Size(46, 20);
            this.LblUPC.TabIndex = 2;
            this.LblUPC.Text = "UPC:";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(27, 79);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(93, 20);
            this.LblDescription.TabIndex = 3;
            this.LblDescription.Text = "Description:";
            // 
            // LblReleaseDate
            // 
            this.LblReleaseDate.AutoSize = true;
            this.LblReleaseDate.Location = new System.Drawing.Point(507, 22);
            this.LblReleaseDate.Name = "LblReleaseDate";
            this.LblReleaseDate.Size = new System.Drawing.Size(111, 20);
            this.LblReleaseDate.TabIndex = 4;
            this.LblReleaseDate.Text = "Release Date:";
            // 
            // LblPlatform
            // 
            this.LblPlatform.AutoSize = true;
            this.LblPlatform.Location = new System.Drawing.Point(18, 22);
            this.LblPlatform.Name = "LblPlatform";
            this.LblPlatform.Size = new System.Drawing.Size(72, 20);
            this.LblPlatform.TabIndex = 5;
            this.LblPlatform.Text = "Platform:";
            // 
            // LblPurchDate
            // 
            this.LblPurchDate.AutoSize = true;
            this.LblPurchDate.Location = new System.Drawing.Point(399, 22);
            this.LblPurchDate.Name = "LblPurchDate";
            this.LblPurchDate.Size = new System.Drawing.Size(48, 20);
            this.LblPurchDate.TabIndex = 6;
            this.LblPurchDate.Text = "Date:";
            // 
            // LblPurchAmt
            // 
            this.LblPurchAmt.AutoSize = true;
            this.LblPurchAmt.Location = new System.Drawing.Point(555, 22);
            this.LblPurchAmt.Name = "LblPurchAmt";
            this.LblPurchAmt.Size = new System.Drawing.Size(69, 20);
            this.LblPurchAmt.TabIndex = 7;
            this.LblPurchAmt.Text = "Amount:";
            // 
            // LblPurchLoc
            // 
            this.LblPurchLoc.AutoSize = true;
            this.LblPurchLoc.Location = new System.Drawing.Point(626, 22);
            this.LblPurchLoc.Name = "LblPurchLoc";
            this.LblPurchLoc.Size = new System.Drawing.Size(74, 20);
            this.LblPurchLoc.TabIndex = 8;
            this.LblPurchLoc.Text = "Location:";
            // 
            // LblRetailAmt
            // 
            this.LblRetailAmt.AutoSize = true;
            this.LblRetailAmt.Location = new System.Drawing.Point(507, 79);
            this.LblRetailAmt.Name = "LblRetailAmt";
            this.LblRetailAmt.Size = new System.Drawing.Size(114, 20);
            this.LblRetailAmt.TabIndex = 9;
            this.LblRetailAmt.Text = "Retail Amount:";
            // 
            // LblDiscount
            // 
            this.LblDiscount.AutoSize = true;
            this.LblDiscount.Location = new System.Drawing.Point(782, 22);
            this.LblDiscount.Name = "LblDiscount";
            this.LblDiscount.Size = new System.Drawing.Size(76, 20);
            this.LblDiscount.TabIndex = 10;
            this.LblDiscount.Text = "Discount:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(789, 32);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(150, 50);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(789, 232);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(150, 50);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.Color.White;
            this.BtnRemove.Enabled = false;
            this.BtnRemove.Location = new System.Drawing.Point(789, 132);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(150, 50);
            this.BtnRemove.TabIndex = 5;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.White;
            this.BtnSearch.Enabled = false;
            this.BtnSearch.Location = new System.Drawing.Point(486, 20);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(150, 50);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TbSearch
            // 
            this.TbSearch.Location = new System.Drawing.Point(6, 32);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(474, 26);
            this.TbSearch.TabIndex = 0;
            // 
            // TbTitle
            // 
            this.TbTitle.Location = new System.Drawing.Point(31, 45);
            this.TbTitle.Name = "TbTitle";
            this.TbTitle.Size = new System.Drawing.Size(474, 26);
            this.TbTitle.TabIndex = 2;
            this.TbTitle.Text = "Middle-Earth Shadow of Mordor";
            // 
            // TbUPC
            // 
            this.TbUPC.Location = new System.Drawing.Point(269, 45);
            this.TbUPC.Name = "TbUPC";
            this.TbUPC.Size = new System.Drawing.Size(128, 26);
            this.TbUPC.TabIndex = 8;
            this.TbUPC.Text = "883929319572";
            // 
            // TbDescription
            // 
            this.TbDescription.Location = new System.Drawing.Point(31, 102);
            this.TbDescription.Multiline = true;
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(474, 85);
            this.TbDescription.TabIndex = 3;
            this.TbDescription.Text = "An Entirely Fresh Open World Experience - Gamespot";
            // 
            // TbDiscount
            // 
            this.TbDiscount.Location = new System.Drawing.Point(786, 45);
            this.TbDiscount.Name = "TbDiscount";
            this.TbDiscount.Size = new System.Drawing.Size(72, 26);
            this.TbDiscount.TabIndex = 12;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.White;
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Location = new System.Drawing.Point(789, 82);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(150, 50);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            // 
            // DtpReleaseDate
            // 
            this.DtpReleaseDate.CustomFormat = "MM/dd/yyyy";
            this.DtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpReleaseDate.Location = new System.Drawing.Point(511, 45);
            this.DtpReleaseDate.Name = "DtpReleaseDate";
            this.DtpReleaseDate.Size = new System.Drawing.Size(198, 26);
            this.DtpReleaseDate.TabIndex = 4;
            this.DtpReleaseDate.Value = new System.DateTime(2014, 9, 30, 0, 0, 0, 0);
            // 
            // DtpPurchDate
            // 
            this.DtpPurchDate.CustomFormat = "MM/dd/yyyy";
            this.DtpPurchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpPurchDate.Location = new System.Drawing.Point(403, 45);
            this.DtpPurchDate.Name = "DtpPurchDate";
            this.DtpPurchDate.Size = new System.Drawing.Size(150, 26);
            this.DtpPurchDate.TabIndex = 9;
            this.DtpPurchDate.Value = new System.DateTime(2015, 9, 30, 0, 0, 0, 0);
            // 
            // MtbPurchAmt
            // 
            this.MtbPurchAmt.Location = new System.Drawing.Point(559, 45);
            this.MtbPurchAmt.Mask = "$99.00";
            this.MtbPurchAmt.Name = "MtbPurchAmt";
            this.MtbPurchAmt.Size = new System.Drawing.Size(65, 26);
            this.MtbPurchAmt.TabIndex = 10;
            this.MtbPurchAmt.Text = "1499";
            this.MtbPurchAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MtbPurchAmt.Leave += new System.EventHandler(this.MtbPurchAmt_Leave);
            // 
            // MtbRetailAmt
            // 
            this.MtbRetailAmt.Location = new System.Drawing.Point(511, 102);
            this.MtbRetailAmt.Mask = "$99.00";
            this.MtbRetailAmt.Name = "MtbRetailAmt";
            this.MtbRetailAmt.Size = new System.Drawing.Size(198, 26);
            this.MtbRetailAmt.TabIndex = 5;
            this.MtbRetailAmt.Text = "5999";
            this.MtbRetailAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MtbRetailAmt.Leave += new System.EventHandler(this.MtbRetailAmt_Leave);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(789, 182);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(150, 50);
            this.BtnClear.TabIndex = 6;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // CmbPurchLoc
            // 
            this.CmbPurchLoc.FormattingEnabled = true;
            this.CmbPurchLoc.Items.AddRange(new object[] {
            "Amazon",
            "Best Buy",
            "Gamestop",
            "Garage Sale",
            "NewEgg",
            "Target",
            "Toys-R-Us",
            "Wal-Mart"});
            this.CmbPurchLoc.Location = new System.Drawing.Point(630, 45);
            this.CmbPurchLoc.Name = "CmbPurchLoc";
            this.CmbPurchLoc.Size = new System.Drawing.Size(150, 28);
            this.CmbPurchLoc.TabIndex = 11;
            this.CmbPurchLoc.Text = "Amazon";
            // 
            // CmbPlatform
            // 
            this.CmbPlatform.FormattingEnabled = true;
            this.CmbPlatform.Items.AddRange(new object[] {
            "Nintendo 2DS",
            "Nintendo 3DS",
            "Nintendo Wii",
            "Nintendo Wii U",
            "Nintendo Switch",
            "Playstation",
            "Playstation 2",
            "Playstation 3",
            "Playstation 4",
            "NES",
            "SNES",
            "Sega Genesis",
            "Xbox",
            "Xbox 360",
            "Xbox One"});
            this.CmbPlatform.Location = new System.Drawing.Point(22, 45);
            this.CmbPlatform.Name = "CmbPlatform";
            this.CmbPlatform.Size = new System.Drawing.Size(241, 28);
            this.CmbPlatform.TabIndex = 7;
            this.CmbPlatform.Text = "Xbox One";
            // 
            // GbPurchases
            // 
            this.GbPurchases.Controls.Add(this.CbDigital);
            this.GbPurchases.Controls.Add(this.CmbPlatform);
            this.GbPurchases.Controls.Add(this.CmbPurchLoc);
            this.GbPurchases.Controls.Add(this.LblUPC);
            this.GbPurchases.Controls.Add(this.LblPlatform);
            this.GbPurchases.Controls.Add(this.TbUPC);
            this.GbPurchases.Controls.Add(this.MtbPurchAmt);
            this.GbPurchases.Controls.Add(this.LblPurchDate);
            this.GbPurchases.Controls.Add(this.TbDiscount);
            this.GbPurchases.Controls.Add(this.DtpPurchDate);
            this.GbPurchases.Controls.Add(this.LblPurchAmt);
            this.GbPurchases.Controls.Add(this.LblPurchLoc);
            this.GbPurchases.Controls.Add(this.LblDiscount);
            this.GbPurchases.Location = new System.Drawing.Point(12, 324);
            this.GbPurchases.Name = "GbPurchases";
            this.GbPurchases.Size = new System.Drawing.Size(927, 95);
            this.GbPurchases.TabIndex = 2;
            this.GbPurchases.TabStop = false;
            this.GbPurchases.Text = "Purchases";
            // 
            // CbDigital
            // 
            this.CbDigital.AutoSize = true;
            this.CbDigital.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CbDigital.Location = new System.Drawing.Point(864, 21);
            this.CbDigital.Name = "CbDigital";
            this.CbDigital.Size = new System.Drawing.Size(57, 45);
            this.CbDigital.TabIndex = 13;
            this.CbDigital.Text = "Digital";
            this.CbDigital.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CbDigital.UseVisualStyleBackColor = true;
            // 
            // GbGenDetails
            // 
            this.GbGenDetails.Controls.Add(this.LlRatings);
            this.GbGenDetails.Controls.Add(this.CmbRating);
            this.GbGenDetails.Controls.Add(this.LblTitle);
            this.GbGenDetails.Controls.Add(this.TbTitle);
            this.GbGenDetails.Controls.Add(this.LblDescription);
            this.GbGenDetails.Controls.Add(this.MtbRetailAmt);
            this.GbGenDetails.Controls.Add(this.TbDescription);
            this.GbGenDetails.Controls.Add(this.DtpReleaseDate);
            this.GbGenDetails.Controls.Add(this.LblReleaseDate);
            this.GbGenDetails.Controls.Add(this.LblRetailAmt);
            this.GbGenDetails.Location = new System.Drawing.Point(12, 98);
            this.GbGenDetails.Name = "GbGenDetails";
            this.GbGenDetails.Size = new System.Drawing.Size(771, 217);
            this.GbGenDetails.TabIndex = 1;
            this.GbGenDetails.TabStop = false;
            this.GbGenDetails.Text = "General Details";
            // 
            // LlRatings
            // 
            this.LlRatings.AutoSize = true;
            this.LlRatings.Location = new System.Drawing.Point(507, 136);
            this.LlRatings.Name = "LlRatings";
            this.LlRatings.Size = new System.Drawing.Size(109, 20);
            this.LlRatings.TabIndex = 6;
            this.LlRatings.Text = "ESRB Rating:";
            this.LlRatings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlRatings_LinkClicked);
            // 
            // CmbRating
            // 
            this.CmbRating.FormattingEnabled = true;
            this.CmbRating.Items.AddRange(new object[] {
            "E - Everyone",
            "E10+ - Everyone 10+",
            "T - Teen",
            "M - Mature 17+",
            "AO - Adult Only 18+",
            "RP - Rating Pending"});
            this.CmbRating.Location = new System.Drawing.Point(511, 159);
            this.CmbRating.Name = "CmbRating";
            this.CmbRating.Size = new System.Drawing.Size(197, 28);
            this.CmbRating.TabIndex = 7;
            this.CmbRating.Text = "T - Teen";
            // 
            // GbSearch
            // 
            this.GbSearch.Controls.Add(this.TbSearch);
            this.GbSearch.Controls.Add(this.BtnSearch);
            this.GbSearch.Location = new System.Drawing.Point(12, 12);
            this.GbSearch.Name = "GbSearch";
            this.GbSearch.Size = new System.Drawing.Size(771, 80);
            this.GbSearch.TabIndex = 0;
            this.GbSearch.TabStop = false;
            this.GbSearch.Text = "Search Existing Game:";
            // 
            // VideoGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 471);
            this.Controls.Add(this.GbSearch);
            this.Controls.Add(this.GbGenDetails);
            this.Controls.Add(this.GbPurchases);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.StatusStrip);
            this.Name = "VideoGameForm";
            this.Text = "Video Games";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.GbPurchases.ResumeLayout(false);
            this.GbPurchases.PerformLayout();
            this.GbGenDetails.ResumeLayout(false);
            this.GbGenDetails.PerformLayout();
            this.GbSearch.ResumeLayout(false);
            this.GbSearch.PerformLayout();
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
        private System.Windows.Forms.TextBox TbSearch;
        private System.Windows.Forms.TextBox TbTitle;
        private System.Windows.Forms.TextBox TbUPC;
        private System.Windows.Forms.TextBox TbDescription;
        private System.Windows.Forms.TextBox TbDiscount;
        private System.Windows.Forms.ToolStripStatusLabel tSSLable;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.DateTimePicker DtpReleaseDate;
        private System.Windows.Forms.DateTimePicker DtpPurchDate;
        private System.Windows.Forms.MaskedTextBox MtbPurchAmt;
        private System.Windows.Forms.MaskedTextBox MtbRetailAmt;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.ComboBox CmbPurchLoc;
        private System.Windows.Forms.ComboBox CmbPlatform;
        private System.Windows.Forms.GroupBox GbPurchases;
        private System.Windows.Forms.CheckBox CbDigital;
        private System.Windows.Forms.GroupBox GbGenDetails;
        private System.Windows.Forms.ComboBox CmbRating;
        private System.Windows.Forms.LinkLabel LlRatings;
        private System.Windows.Forms.GroupBox GbSearch;
    }
}