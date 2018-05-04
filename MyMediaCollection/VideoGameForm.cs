using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //ToDo Need to check for if anything is available to add (what is minimum)
            //ToDo Need to clearly indicate which minimum fields are missing
            //Todo need to add in date added to database
            //Todo need to add in person entering the information
            VideoGame game = new VideoGame
            {
                Title = TbTitle?.Text,
                UPC = TbUPC?.Text,
                Description = TbDescription?.Text,
                ReleaseDate = DtpReleaseDate.Value,
                Platform = TbPlatform?.Text,
                PurchDate = DtpPurchDate.Value,
                PurchLoc = TbPurchLoc?.Text,
                Discount = TbDiscount?.Text
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
            sb.Append("PURCHASELOCATION,RETAILAMT,DISCOUNT) VALUES ('");
            sb.Append(game.UPC + "','" + game.Title + "','" + game.Description + "','" + game.ReleaseDate + "','" + game.Platform);
            sb.Append("','" + game.PurchDate + "','" + game.PurchAmt + "','" + game.PurchLoc + "','" + game.RetailAmt + "','");
            sb.Append(game.Discount + "')");

            tSSLable.Text = game.AddGame(sb.ToString());
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
            TbPlatform.Text = "";
            DtpReleaseDate.Value = DateTime.Now;
            DtpPurchDate.Value = DateTime.Now;
            MtbRetailAmt.Text = "";
            MtbPurchAmt.Text = "";
            TbPurchLoc.Text = "";
            TbDiscount.Text = "";
        }

        /*void VideoGameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }*/
    }
}
