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
        internal static string GetConnectionString()
        {
            string returnString = null;

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["MyMediaCollection.Properties.Settings.connString"];

            if (settings != null)
                returnString = settings.ConnectionString;

            return returnString;
        }
    }
}
