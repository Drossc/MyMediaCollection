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
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
            //ToDo Setup Books Form
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            TbSearch.Text = "";
            TbTitle.Text = "";
            TbDescription.Text = "";
            DtpReleaseDate.Value = DateTime.Now;
            MtbRetailAmt.Text = "";
            CbDigital.Checked = false;
            CbPhysical.Checked = false;
            DtpPurchDate.Text = "";
            MtbPurchAmt.Text = "";
            CmbPurchLoc.Text = "";
            TbDiscount.Text = "";
            TbUPC.Text = "";
        }
    }
}
