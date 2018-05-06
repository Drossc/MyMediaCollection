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
    public partial class MusicForm : Form
    {
        public MusicForm()
        {
            InitializeComponent();
            //ToDo Setup Music Form
        }

        private void LlRatings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ToDo Add in ability to pull up default webrowser to https://www.riaa.com/resources-learning/parental-advisory-label/
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
