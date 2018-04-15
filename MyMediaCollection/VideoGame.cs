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
        public string ReleaseDate;
        /// <summary>
        /// Platform game was purchased on.
        /// </summary>
        public string Platform;
        /// <summary>
        /// Date game was purchased on.
        /// </summary>
        public string PurchDate;
        /// <summary>
        /// Amount game was purchased for.
        /// </summary>
        public string PurchAmt;
        /// <summary>
        /// Location purchase took place at.
        /// </summary>
        public string PurchLoc;
        /// <summary>
        /// Original retail amount game released for.
        /// </summary>
        public string RetailAmt;
        /// <summary>
        /// Difference between Retail Amount and Purchase Amount.
        /// </summary>
        public string Discount;

        internal void AddGame(string cmdText)
        {
            string connectionString = Utility.GetConnectionString();
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmdNewGame = new SqlCommand();
                cmdNewGame.CommandType = CommandType.Text;
                cmdNewGame.CommandText = cmdText;
                cmdNewGame.Connection = connection;
                connection.Open();
                cmdNewGame.ExecuteNonQuery();
                connection.Close();
                //Todo Add Notification to Status Bar to indicate game was added
            }
            //Todo Notify User of Completion/Error
        }
    }
}
