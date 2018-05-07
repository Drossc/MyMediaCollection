using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyMediaCollection
{
    public partial class VideoGameForm : Form
    {
        public VideoGameForm()
        {
            InitializeComponent();
        }

        //ToDo May need a display of found video games to select from


        private void BtnExit_Click(object sender, EventArgs e)
        {
            //ToDo need to see if changes made and should be saved
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TbTitle.Text != "" && CmbPlatform.Text != "")
            { 
                VideoGame game = new VideoGame
                {
                    Title = TbTitle?.Text,
                    UPC = TbUPC?.Text,
                    Description = TbDescription?.Text,
                    ReleaseDate = DtpReleaseDate.Value,
                    Platform = CmbPlatform?.Text,
                    PurchDate = DtpPurchDate.Value,
                    PurchLoc = CmbPurchLoc?.Text,
                    Discount = TbDiscount?.Text.Replace("%",""),
                    Rating = CmbRating?.Text,
                    Digital = CbDigital.Checked,
                    DateAdded = DateTime.Now,
                    AddedBy = "Someone"
                };

                if (MtbPurchAmt.Text != "$  .")
                {
                    game.PurchAmt = Convert.ToDecimal(MtbPurchAmt.Text.Replace("$", "").Replace(" ", ""));
                }

                if (MtbRetailAmt.Text != "$  .")
                {
                    game.RetailAmt = Convert.ToDecimal(MtbRetailAmt.Text.Replace("$", "").Replace(" ", ""));
                }

                StringBuilder sb = new StringBuilder();
                sb.Append ("INSERT VGTable (UPC,TITLE,DESCRIPTION,RELEASEDATE,PLATFORM,PURCHASEDATE,PURCHASEAMT,");
                sb.Append("PURCHASELOCATION,RETAILAMT,DISCOUNT,RATING,DIGITAL,DATEADDED,ADDEDBY) VALUES ('");
                sb.Append(game.UPC + "','" + game.Title + "','" + game.Description + "','" + game.ReleaseDate + "','" + game.Platform);
                sb.Append("','" + game.PurchDate + "','" + game.PurchAmt + "','" + game.PurchLoc + "','" + game.RetailAmt + "','");
                sb.Append(game.Discount + "','" + game.Rating + "','" + game.Digital + "','" + game.DateAdded + "','" + game.AddedBy + "')");

                TbTitle.BackColor = (Color.FromKnownColor(KnownColor.Window));
                CmbPlatform.BackColor = (Color.FromKnownColor(KnownColor.Window));
                tSSLable.Text = Utility.AddMedia(sb.ToString(), game.DateAdded);
            }
            else
            {
                tSSLable.Text = "Please enter the Game Title and Platform.";
                if (TbTitle.Text == ""){ TbTitle.BackColor = Color.Red; }
                if (CmbPlatform.Text == "") { CmbPlatform.BackColor = Color.Red; }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //ToDo Recall Added Video Games from Db to Show Information
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            //ToDo Remove an Existing Video Game from the DB
        }

        private void MtbPurchAmt_Leave(object sender, EventArgs e)
        {
            TbDiscount.Text = Utility.CalcDiscount(MtbRetailAmt.Text, MtbPurchAmt.Text);
        }

        private void MtbRetailAmt_Leave(object sender, EventArgs e)
        {
            TbDiscount.Text = Utility.CalcDiscount(MtbRetailAmt.Text, MtbPurchAmt.Text);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //Have loop go through each of the controls on the form and clear value
            TbSearch.Text = "";
            TbUPC.Text = "";
            TbTitle.Text = "";
            TbDescription.Text = "";
            CmbPlatform.Text = "";
            DtpReleaseDate.Value = DateTime.Now;
            DtpPurchDate.Value = DateTime.Now;
            MtbRetailAmt.Text = "";
            MtbPurchAmt.Text = "";
            CmbPurchLoc.Text = "";
            TbDiscount.Text = "";
            CmbRating.Text = "";
            CbDigital.Checked = false;
        }

        private void LlRatings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ToDo Need to add in link to default brower to esrb site http://www.esrb.org/
        }
    }
}
