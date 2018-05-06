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
    public partial class Cinema : Form
    {
        public Cinema()
        {
            InitializeComponent();
            //ToDo Setup Cinema Form
        }

        private void LlRatings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ToDo Need to add in pull up default web browser and go to https://www.mpaa.org/
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
