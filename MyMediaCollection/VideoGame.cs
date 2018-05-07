using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyMediaCollection
{
    public class VideoGame : Media
    {
        /// <summary>
        /// Platform game was purchased on.
        /// </summary>
        public string Platform;
        /// <summary>
        /// Public game rating.
        /// </summary>
        public string Rating;
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
