using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            //ToDo Pull in Values Variable
            string vgTitle = TbTitle?.Text;
            string vgUPC = TbUPC?.Text;
            string vgDescription = TbDescription?.Text;
            string vgReleaseDate = TbReleaseDate?.Text;
            string vgPlatform = TbPlatform?.Text;
            string vgPurchDate = TbPurchDate?.Text;
            string vgPurchAmt = TbPurchAmt?.Text;
            string vgPurchLoc = TbPurchLoc?.Text;
            string vgRetailAmt = TbRetailAmt?.Text;
            string vgDiscount = TbDiscount?.Text;

            StringBuilder sb = new StringBuilder();
            sb.Append ("INSERT [UPC,TITLE,DESCRIPTION,RELEASEDATE,PLATFORM,PURHCASEDATE,PURCHASEAMT,");
            sb.Append("PURCHASELOCATION,RETAILAMT,DISCOUNT,DATEADDED,ADDEDBY] VALUES (");
            sb.Append(vgUPC + "," + vgTitle + "," + vgDescription + "," + vgReleaseDate + "," + vgPlatform + "," + vgPurchDate + ",");
            sb.Append(vgPurchAmt + "," + vgPurchLoc + "," + vgRetailAmt + "," + vgDiscount + ")");

            //Todo Insert Values to VGTable
            string connectionString = Utility.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.ExecuteNonQuery();
            connection.Close();

            //Todo Notify User of Completion/Error
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
