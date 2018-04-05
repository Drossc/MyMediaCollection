using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            //Todo Connect to DB
            //Todo Insert Values to VGTable
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
