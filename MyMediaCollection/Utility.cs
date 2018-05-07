using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MyMediaCollection
{
    class Utility
    {
        /// <summary>
        /// Pulls connection string from settings.
        /// </summary>
        /// <returns></returns>
        internal static string GetConnectionString()
        {
            string returnString = null;

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["MyMediaCollection.Properties.Settings.connString"];

            if (settings != null)
                returnString = settings.ConnectionString;

            return returnString;
        }

        /// <summary>
        /// Calculates discount value from purchase and retail amounts.
        /// </summary>
        /// <param name="retailAmt"></param>
        /// <param name="purchAmt"></param>
        /// <returns></returns>
        internal static string CalcDiscount(string retailAmt, string purchAmt)
        {
            string sDiscount;

            purchAmt = (purchAmt).Replace("$", "");
            purchAmt = (purchAmt).Replace(" ", "");
            retailAmt = (retailAmt).Replace("$", "");
            retailAmt = (retailAmt).Replace(" ", "");

            if (purchAmt == "." || retailAmt == ".")
            {
                sDiscount = "";
            }
            else
            {
                decimal dPurchAmt = Convert.ToDecimal(purchAmt);
                decimal dRetailAmt = Convert.ToDecimal(retailAmt);
                decimal dDiscount = (100 - ((dPurchAmt / dRetailAmt) * 100));
                int iDiscount = Convert.ToInt16(dDiscount);
                sDiscount = Convert.ToString(iDiscount) + "%";
            }

            return sDiscount;
        }

        //ToDo This maybe able to be moved to Utility class to be shared amongst all media classes
        /// <summary>
        /// Adds game to database while returning status message.
        /// </summary>
        /// <param name="cmdText"></param>
        /// <returns></returns>
        internal static string AddMedia(string cmdText, DateTime dateAdded)
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
                        statusMsg = Convert.ToString(dateAdded) + " Added Successfully!";
                        break;
                    case ConnectionState.Open:
                        cmdNewGame.ExecuteNonQuery();
                        connection.Close();
                        statusMsg = Convert.ToString(dateAdded) + " Added Successfully!";
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
                        statusMsg = Convert.ToString(dateAdded) + " Not Added. Connection Broken.";
                        break;
                }
            }
            return statusMsg;
        }
    }
}
