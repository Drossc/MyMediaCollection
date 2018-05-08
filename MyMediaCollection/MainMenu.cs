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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            //ToDo Need to add in settings for stores
        }

        public AppUser appUser = new AppUser();

        private void BtnBooks_Click(object sender, EventArgs e)
        {
            BooksForm booksForm = new BooksForm();
            booksForm.ShowDialog();
        }

        private void BtnCinema_Click(object sender, EventArgs e)
        {
            Cinema cinemaForm = new Cinema();
            cinemaForm.ShowDialog();
        }

        private void BtnMusic_Click(object sender, EventArgs e)
        {
            MusicForm musicForm = new MusicForm();
            musicForm.ShowDialog();
        }

        private void BtnVideoGames_Click(object sender, EventArgs e)
        {
            VideoGameForm videoGameForm = new VideoGameForm();
            videoGameForm.LoadWindow(appUser.Name);
            videoGameForm.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CmbAppUser_TextChanged(object sender, EventArgs e)
        {
             tssLabel.Text = CheckForUser()? "" : "Collector was not found.";
            //ToDo Need to remove the abilyt to add collectors if the textbox is blank or already exists
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            //ToDo Need to be tied into user table in database
            if (!CmbAppUser.Items.Contains(CmbAppUser.Text) && (CmbAppUser.Text != ""))
            {
                CmbAppUser.Items.Add(CmbAppUser.Text);
            }

            tssLabel.Text = CheckForUser()? "Collector Added." : "Collector Not Added";
        }

        private void BtnRemoveUser_Click(object sender, EventArgs e)
        {
            //ToDo Need to remove user from table in database
            CmbAppUser.Items.Remove(CmbAppUser.Text);
            tssLabel.Text = CheckForUser()? "Collector Removed." : "Collector Not Removed";
        }

        internal bool CheckForUser()
        {
            bool wasFound;
            if (CmbAppUser.Items.Contains(CmbAppUser.Text))
            {
                appUser.Name = CmbAppUser.Text;
                BtnBooks.Enabled = true;
                BtnCinema.Enabled = true;
                BtnMusic.Enabled = true;
                BtnVideoGames.Enabled = true;
                wasFound = true;
            }
            else
            {
                BtnBooks.Enabled = false;
                BtnCinema.Enabled = false;
                BtnMusic.Enabled = false;
                BtnVideoGames.Enabled = false;
                wasFound = false;
            }
            return (wasFound);
        }
    }
}
