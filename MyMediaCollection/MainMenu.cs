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
            //ToDo Complete Initial Design of Main Menu
            //ToDo May hide main menu during use of other forms
            //ToDo Need to add in settings for stores
            //ToDo Need to establish how to create a user
        }

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
            videoGameForm.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
