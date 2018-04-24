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
        /// Adds game to database while returning status message.
        /// </summary>
        /// <param name="cmdText"></param>
        /// <returns></returns>
        public string AddGame(string cmdText)
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
                        statusMsg = Convert.ToString(DateTime.Now) + " Game Added Successfully!";
                        break;
                    case ConnectionState.Open:
                        cmdNewGame.ExecuteNonQuery();
                        connection.Close();
                        statusMsg = Convert.ToString(DateTime.Now) + " Game Added Successfully!";
                        break;
                    case ConnectionState.Connecting:
                        statusMsg = Convert.ToString(DateTime.Now) + " Still Connecting, Addition Failed.";
                        break;
                    case ConnectionState.Executing:
                        statusMsg = Convert.ToString(DateTime.Now) + " Still Executing!";
                        break;
                    case ConnectionState.Fetching:
                        statusMsg = Convert.ToString(DateTime.Now) + " Still Fetching Results.";
                        break;
                    case ConnectionState.Broken:
                        statusMsg = Convert.ToString(DateTime.Now) + " Game Not Added. Connection Broken.";
                        break;
                }
            }
            return statusMsg;
        }
    }
}
