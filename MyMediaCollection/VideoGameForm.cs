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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //Todo need to add in date added to database
            //Todo need to add in person entering the information
            VideoGame game = new VideoGame
            {
                Title = TbTitle?.Text,
                UPC = TbUPC?.Text,
                Description = TbDescription?.Text,
                //ReleaseDate = TbReleaseDate?.Text,
                ReleaseDate = DtpReleaseDate.Value,
                Platform = TbPlatform?.Text,
                //PurchDate = TbPurchDate?.Text,
                PurchDate = DtpPurchDate.Value,
                //PurchAmt = TbPurchAmt?.Text,
                //This may not work but need to test to see if a decimal is recorded.
                PurchAmt = Convert.ToDecimal(MtbPurchAmt?.Text),
                PurchLoc = TbPurchLoc?.Text,
                //RetailAmt = TbRetailAmt?.Text,
                RetailAmt = Convert.ToDecimal(MtbRetailAmt?.Text),
                Discount = TbDiscount?.Text
            };

            
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

        private void TbReleaseDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblPlatform_Click(object sender, EventArgs e)
        {

        }

        private void MtbPurchAmt_Leave(object sender, EventArgs e)
        {
            //ToDo Need to only make calculation if numerical value is present
            string sPurchAmt = MtbPurchAmt.Text;
            sPurchAmt = (sPurchAmt).Replace("$", "");
            sPurchAmt = (sPurchAmt).Replace(" ", "");
            decimal dPurchAmt = Convert.ToDecimal(sPurchAmt);
            string sRetailAmt = MtbRetailAmt.Text;
            sRetailAmt = (sRetailAmt).Replace("$", "");
            sRetailAmt = (sRetailAmt).Replace(" ", "");
            decimal dRetailAmt = Convert.ToDecimal(sRetailAmt);
            decimal dDiscount = (dPurchAmt / dRetailAmt) *100;
            int iDiscount = Convert.ToInt16(dDiscount);
            TbDiscount.Text = Convert.ToString(iDiscount) + "%";
        }

        private void MtbPurchAmt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        //ToDo Need to be able to clear out form fields after performing an event
    }
}
