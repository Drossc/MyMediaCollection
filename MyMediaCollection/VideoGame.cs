using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyMediaCollection
{
    public class VideoGame
    {
        /// <summary>
        /// Title of the game.
        /// </summary>
        public string Title;
        /// <summary>
        /// UPC from the back of the game.
        /// </summary>
        public string UPC;
        /// <summary>
        /// Description the game.
        /// </summary>
        public string Description;
        /// <summary>
        /// Initial release date of the game.
        /// </summary>
        public DateTime ReleaseDate;
        /// <summary>
        /// Platform game was purchased on.
        /// </summary>
        public string Platform;
        /// <summary>
        /// Date game was purchased on.
        /// </summary>
        public DateTime PurchDate;
        /// <summary>
        /// Amount game was purchased for.
        /// </summary>
        public decimal PurchAmt;
        /// <summary>
        /// Location purchase took place at.
        /// </summary>
        public string PurchLoc;
        /// <summary>
        /// Original retail amount game released for.
        /// </summary>
        public decimal RetailAmt;
        /// <summary>
        /// Difference between Retail Amount and Purchase Amount.
        /// </summary>
        public string Discount;
        /// <summary>
        /// Public game rating.
        /// </summary>
        public string Rating;
        /// <summary>
        /// Identifies if purchase was done digitally.
        /// </summary>
        public bool Digital;
        /// <summary>
        /// Date added to database.
        /// </summary>
        public DateTime DateAdded;
        /// <summary>
        /// Username of person adding/updating information.
        /// </summary>
        public string AddedBy;

        /// <summary>
        /// Adds game to database while returning status message.
        /// </summary>
        /// <param name="cmdText"></param>
        /// <returns></returns>
        public string AddGame(string cmdText, DateTime dateAdded)
        {
            string statusMsg = null;
            string connectionString = Utility.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmdNewGame = new SqlCommand();
                cmdNewGame.CommandType = CommandType.Text;
                cmdNewGame.CommandText = cmdText;
                cmdNewGame.Connection = connection;

                switch (connection.State)
                {
                    case ConnectionState.Closed:
                        connection.Open();
                        cmdNewGame.ExecuteNonQuery();
                        connection.Close();
                        statusMsg = Convert.ToString(dateAdded) + " Game Added Successfully!";
                        break;
                    case ConnectionState.Open:
                        cmdNewGame.ExecuteNonQuery();
                        connection.Close();
                        statusMsg = Convert.ToString(dateAdded) + " Game Added Successfully!";
                        break;
                    case ConnectionState.Connecting:
                        statusMsg = Convert.ToString(dateAdded) + " Still Connecting, Addition Failed.";
                        break;
                    case ConnectionState.Executing:
                        statusMsg = Convert.ToString(dateAdded) + " Still Executing!";
                        break;
                    case ConnectionState.Fetching:
                        statusMsg = Convert.ToString(dateAdded) + " Still Fetching Results.";
                        break;
                    case ConnectionState.Broken:
                        statusMsg = Convert.ToString(dateAdded) + " Game Not Added. Connection Broken.";
                        break;
                }
            }
            return statusMsg;
        }
    }
}
