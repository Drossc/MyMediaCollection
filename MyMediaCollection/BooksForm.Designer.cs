namespace MyMediaCollection
{
    partial class BooksForm
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.tSSLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.CmbPurchLoc = new System.Windows.Forms.ComboBox();
            this.TbUPC = new System.Windows.Forms.TextBox();
            this.GbPurchases = new System.Windows.Forms.GroupBox();
            this.LblUPC = new System.Windows.Forms.Label();
            this.CbPhysical = new System.Windows.Forms.CheckBox();
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.GbGenDetails = new System.Windows.Forms.GroupBox();
            this.TbTitle = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.MtbRetailAmt = new System.Windows.Forms.MaskedTextBox();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.DtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.LblReleaseDate = new System.Windows.Forms.Label();
            this.CbHardBack = new System.Windows.Forms.CheckBox();
            this.StatusStrip.SuspendLayout();
            this.GbPurchases.SuspendLayout();
            this.GbSearch.SuspendLayout();
            this.GbGenDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(455, 18);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(100, 32);
            this.BtnAdd.TabIndex = 21;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(455, 148);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(100, 32);
            this.BtnExit.TabIndex = 25;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.Color.White;
            this.BtnRemove.Enabled = false;
            this.BtnRemove.Location = new System.Drawing.Point(455, 83);
            this.BtnRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(100, 32);
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
            this.BtnClear.Location = new System.Drawing.Point(455, 115);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(100, 32);
            this.BtnClear.TabIndex = 24;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.White;
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Location = new System.Drawing.Point(455, 50);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(100, 32);
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
            this.StatusStrip.Location = new System.Drawing.Point(0, 283);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.StatusStrip.Size = new System.Drawing.Size(611, 22);
            this.StatusStrip.TabIndex = 18;
            // 
            // CmbPurchLoc
            // 
            this.CmbPurchLoc.FormattingEnabled = true;
            this.CmbPurchLoc.Items.AddRange(new object[] {
            "Amazon",
            "Barnes and Nobles",
            "Best Buy",
            "Garage Sale",
            "iBooks",
            "Kindle",
            "Target",
            "Toys-R-Us",
            "Wal-Mart"});
            this.CmbPurchLoc.Location = new System.Drawing.Point(259, 33);
            this.CmbPurchLoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbPurchLoc.Name = "CmbPurchLoc";
            this.CmbPurchLoc.Size = new System.Drawing.Size(101, 21);
            this.CmbPurchLoc.TabIndex = 11;
            this.CmbPurchLoc.Text = "Amazon";
            // 
            // TbUPC
            // 
            this.TbUPC.Location = new System.Drawing.Point(417, 33);
            this.TbUPC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbUPC.Name = "TbUPC";
            this.TbUPC.Size = new System.Drawing.Size(87, 20);
            this.TbUPC.TabIndex = 8;
            this.TbUPC.Text = "883929319572";
            // 
            // GbPurchases
            // 
            this.GbPurchases.Controls.Add(this.CbHardBack);
            this.GbPurchases.Controls.Add(this.CmbPurchLoc);
            this.GbPurchases.Controls.Add(this.TbUPC);
            this.GbPurchases.Controls.Add(this.LblUPC);
            this.GbPurchases.Controls.Add(this.CbPhysical);
            this.GbPurchases.Controls.Add(this.MtbPurchAmt);
            this.GbPurchases.Controls.Add(this.LblPurchDate);
            this.GbPurchases.Controls.Add(this.CbDigital);
            this.GbPurchases.Controls.Add(this.TbDiscount);
            this.GbPurchases.Controls.Add(this.DtpPurchDate);
            this.GbPurchases.Controls.Add(this.LblPurchAmt);
            this.GbPurchases.Controls.Add(this.LblPurchLoc);
            this.GbPurchases.Controls.Add(this.LblDiscount);
            this.GbPurchases.Location = new System.Drawing.Point(8, 207);
            this.GbPurchases.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbPurchases.Name = "GbPurchases";
            this.GbPurchases.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbPurchases.Size = new System.Drawing.Size(577, 62);
            this.GbPurchases.TabIndex = 20;
            this.GbPurchases.TabStop = false;
            this.GbPurchases.Text = "Purchases";
            // 
            // LblUPC
            // 
            this.LblUPC.AutoSize = true;
            this.LblUPC.Location = new System.Drawing.Point(417, 19);
            this.LblUPC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblUPC.Name = "LblUPC";
            this.LblUPC.Size = new System.Drawing.Size(32, 13);
            this.LblUPC.TabIndex = 2;
            this.LblUPC.Text = "UPC:";
            // 
            // CbPhysical
            // 
            this.CbPhysical.AutoSize = true;
            this.CbPhysical.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CbPhysical.Location = new System.Drawing.Point(48, 17);
            this.CbPhysical.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbPhysical.Name = "CbPhysical";
            this.CbPhysical.Size = new System.Drawing.Size(50, 31);
            this.CbPhysical.TabIndex = 14;
            this.CbPhysical.Text = "Physical";
            this.CbPhysical.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CbPhysical.UseVisualStyleBackColor = true;
            // 
            // MtbPurchAmt
            // 
            this.MtbPurchAmt.Location = new System.Drawing.Point(210, 33);
            this.MtbPurchAmt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MtbPurchAmt.Mask = "$99.00";
            this.MtbPurchAmt.Name = "MtbPurchAmt";
            this.MtbPurchAmt.Size = new System.Drawing.Size(45, 20);
            this.MtbPurchAmt.TabIndex = 10;
            this.MtbPurchAmt.Text = "1499";
            this.MtbPurchAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblPurchDate
            // 
            this.LblPurchDate.AutoSize = true;
            this.LblPurchDate.Location = new System.Drawing.Point(102, 18);
            this.LblPurchDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPurchDate.Name = "LblPurchDate";
            this.LblPurchDate.Size = new System.Drawing.Size(33, 13);
            this.LblPurchDate.TabIndex = 6;
            this.LblPurchDate.Text = "Date:";
            // 
            // CbDigital
            // 
            this.CbDigital.AutoSize = true;
            this.CbDigital.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CbDigital.Location = new System.Drawing.Point(4, 17);
            this.CbDigital.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbDigital.Name = "CbDigital";
            this.CbDigital.Size = new System.Drawing.Size(40, 31);
            this.CbDigital.TabIndex = 13;
            this.CbDigital.Text = "Digital";
            this.CbDigital.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CbDigital.UseVisualStyleBackColor = true;
            // 
            // TbDiscount
            // 
            this.TbDiscount.Location = new System.Drawing.Point(364, 33);
            this.TbDiscount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbDiscount.Name = "TbDiscount";
            this.TbDiscount.Size = new System.Drawing.Size(49, 20);
            this.TbDiscount.TabIndex = 12;
            // 
            // DtpPurchDate
            // 
            this.DtpPurchDate.CustomFormat = "MM/dd/yyyy";
            this.DtpPurchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpPurchDate.Location = new System.Drawing.Point(105, 33);
            this.DtpPurchDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpPurchDate.Name = "DtpPurchDate";
            this.DtpPurchDate.Size = new System.Drawing.Size(101, 20);
            this.DtpPurchDate.TabIndex = 9;
            this.DtpPurchDate.Value = new System.DateTime(2015, 9, 30, 0, 0, 0, 0);
            // 
            // LblPurchAmt
            // 
            this.LblPurchAmt.AutoSize = true;
            this.LblPurchAmt.Location = new System.Drawing.Point(209, 18);
            this.LblPurchAmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPurchAmt.Name = "LblPurchAmt";
            this.LblPurchAmt.Size = new System.Drawing.Size(46, 13);
            this.LblPurchAmt.TabIndex = 7;
            this.LblPurchAmt.Text = "Amount:";
            // 
            // LblPurchLoc
            // 
            this.LblPurchLoc.AutoSize = true;
            this.LblPurchLoc.Location = new System.Drawing.Point(259, 18);
            this.LblPurchLoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPurchLoc.Name = "LblPurchLoc";
            this.LblPurchLoc.Size = new System.Drawing.Size(51, 13);
            this.LblPurchLoc.TabIndex = 8;
            this.LblPurchLoc.Text = "Location:";
            // 
            // LblDiscount
            // 
            this.LblDiscount.AutoSize = true;
            this.LblDiscount.Location = new System.Drawing.Point(361, 18);
            this.LblDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDiscount.Name = "LblDiscount";
            this.LblDiscount.Size = new System.Drawing.Size(52, 13);
            this.LblDiscount.TabIndex = 10;
            this.LblDiscount.Text = "Discount:";
            // 
            // LblRetailAmt
            // 
            this.LblRetailAmt.AutoSize = true;
            this.LblRetailAmt.Location = new System.Drawing.Point(332, 51);
            this.LblRetailAmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRetailAmt.Name = "LblRetailAmt";
            this.LblRetailAmt.Size = new System.Drawing.Size(76, 13);
            this.LblRetailAmt.TabIndex = 9;
            this.LblRetailAmt.Text = "Retail Amount:";
            // 
            // GbSearch
            // 
            this.GbSearch.Controls.Add(this.TbSearch);
            this.GbSearch.Controls.Add(this.BtnSearch);
            this.GbSearch.Location = new System.Drawing.Point(8, 4);
            this.GbSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbSearch.Name = "GbSearch";
            this.GbSearch.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbSearch.Size = new System.Drawing.Size(443, 52);
            this.GbSearch.TabIndex = 17;
            this.GbSearch.TabStop = false;
            this.GbSearch.Text = "Search Book:";
            // 
            // TbSearch
            // 
            this.TbSearch.Location = new System.Drawing.Point(15, 21);
            this.TbSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(317, 20);
            this.TbSearch.TabIndex = 0;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.White;
            this.BtnSearch.Enabled = false;
            this.BtnSearch.Location = new System.Drawing.Point(335, 13);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(100, 32);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(1, 14);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(30, 13);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Title:";
            // 
            // GbGenDetails
            // 
            this.GbGenDetails.Controls.Add(this.LblTitle);
            this.GbGenDetails.Controls.Add(this.TbTitle);
            this.GbGenDetails.Controls.Add(this.LblDescription);
            this.GbGenDetails.Controls.Add(this.MtbRetailAmt);
            this.GbGenDetails.Controls.Add(this.TbDescription);
            this.GbGenDetails.Controls.Add(this.DtpReleaseDate);
            this.GbGenDetails.Controls.Add(this.LblReleaseDate);
            this.GbGenDetails.Controls.Add(this.LblRetailAmt);
            this.GbGenDetails.Location = new System.Drawing.Point(8, 60);
            this.GbGenDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbGenDetails.Name = "GbGenDetails";
            this.GbGenDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbGenDetails.Size = new System.Drawing.Size(443, 141);
            this.GbGenDetails.TabIndex = 19;
            this.GbGenDetails.TabStop = false;
            this.GbGenDetails.Text = "General Details";
            // 
            // TbTitle
            // 
            this.TbTitle.Location = new System.Drawing.Point(4, 29);
            this.TbTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbTitle.Name = "TbTitle";
            this.TbTitle.Size = new System.Drawing.Size(317, 20);
            this.TbTitle.TabIndex = 2;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(1, 48);
            this.LblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(63, 13);
            this.LblDescription.TabIndex = 3;
            this.LblDescription.Text = "Description:";
            // 
            // MtbRetailAmt
            // 
            this.MtbRetailAmt.Location = new System.Drawing.Point(335, 66);
            this.MtbRetailAmt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MtbRetailAmt.Mask = "$99.00";
            this.MtbRetailAmt.Name = "MtbRetailAmt";
            this.MtbRetailAmt.Size = new System.Drawing.Size(92, 20);
            this.MtbRetailAmt.TabIndex = 5;
            this.MtbRetailAmt.Text = "2999";
            this.MtbRetailAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TbDescription
            // 
            this.TbDescription.Location = new System.Drawing.Point(4, 64);
            this.TbDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbDescription.Multiline = true;
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(317, 57);
            this.TbDescription.TabIndex = 3;
            // 
            // DtpReleaseDate
            // 
            this.DtpReleaseDate.CustomFormat = "MM/dd/yyyy";
            this.DtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpReleaseDate.Location = new System.Drawing.Point(335, 29);
            this.DtpReleaseDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpReleaseDate.Name = "DtpReleaseDate";
            this.DtpReleaseDate.Size = new System.Drawing.Size(92, 20);
            this.DtpReleaseDate.TabIndex = 4;
            this.DtpReleaseDate.Value = new System.DateTime(2014, 9, 30, 0, 0, 0, 0);
            // 
            // LblReleaseDate
            // 
            this.LblReleaseDate.AutoSize = true;
            this.LblReleaseDate.Location = new System.Drawing.Point(332, 14);
            this.LblReleaseDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblReleaseDate.Name = "LblReleaseDate";
            this.LblReleaseDate.Size = new System.Drawing.Size(75, 13);
            this.LblReleaseDate.TabIndex = 4;
            this.LblReleaseDate.Text = "Release Date:";
            // 
            // CbHardBack
            // 
            this.CbHardBack.AutoSize = true;
            this.CbHardBack.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CbHardBack.Location = new System.Drawing.Point(508, 17);
            this.CbHardBack.Margin = new System.Windows.Forms.Padding(2);
            this.CbHardBack.Name = "CbHardBack";
            this.CbHardBack.Size = new System.Drawing.Size(62, 31);
            this.CbHardBack.TabIndex = 15;
            this.CbHardBack.Text = "Hard Back";
            this.CbHardBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CbHardBack.UseVisualStyleBackColor = true;
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(611, 305);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.GbPurchases);
            this.Controls.Add(this.GbSearch);
            this.Controls.Add(this.GbGenDetails);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BooksForm";
            this.Text = "Books";
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

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.ToolStripStatusLabel tSSLable;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ComboBox CmbPurchLoc;
        private System.Windows.Forms.TextBox TbUPC;
        private System.Windows.Forms.GroupBox GbPurchases;
        private System.Windows.Forms.Label LblUPC;
        private System.Windows.Forms.CheckBox CbPhysical;
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
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.GroupBox GbGenDetails;
        private System.Windows.Forms.TextBox TbTitle;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.MaskedTextBox MtbRetailAmt;
        private System.Windows.Forms.TextBox TbDescription;
        private System.Windows.Forms.DateTimePicker DtpReleaseDate;
        private System.Windows.Forms.Label LblReleaseDate;
        private System.Windows.Forms.CheckBox CbHardBack;
    }
}