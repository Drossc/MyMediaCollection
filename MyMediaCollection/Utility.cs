using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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
    }
}
