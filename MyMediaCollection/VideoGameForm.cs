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
                ReleaseDate = TbReleaseDate?.Text,
                Platform = TbPlatform?.Text,
                PurchDate = TbPurchDate?.Text,
                PurchAmt = TbPurchAmt?.Text,
                PurchLoc = TbPurchLoc?.Text,
                RetailAmt = TbRetailAmt?.Text,
                Discount = TbDiscount?.Text
            };

            StringBuilder sb = new StringBuilder();
            sb.Append ("INSERT VGTable (UPC,TITLE,DESCRIPTION,RELEASEDATE,PLATFORM,PURCHASEDATE,PURCHASEAMT,");
            sb.Append("PURCHASELOCATION,RETAILAMT,DISCOUNT) VALUES ('");
            sb.Append(game.UPC + "','" + game.Title + "','" + game.Description + "','" + game.ReleaseDate + "','" + game.Platform);
            sb.Append("','" + game.PurchDate + "','" + game.PurchAmt + "','" + game.PurchLoc + "','" + game.RetailAmt + "','");
            sb.Append(game.Discount + "')");

            game.AddGame(sb.ToString());
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //ToDo Recall Added Video Games from Db to Show Information
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            //ToDo Remove an Existing Video Game from the DB
        }
    }
}
