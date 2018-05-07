using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaCollection
{
    public class Media
    {
        /// <summary>
        /// Username of person adding/updating information.
        /// </summary>
        public string AddedBy;
        /// <summary>
        /// Date added to database.
        /// </summary>
        public DateTime DateAdded;
        /// <summary>
        /// Description the game.
        /// </summary>
        public string Description;
        /// <summary>
        /// Identifies if purchase was done digitally.
        /// </summary>
        public bool Digital;
        /// <summary>
        /// Difference between Retail Amount and Purchase Amount.
        /// </summary>
        public string Discount;
        /// <summary>
        /// Amount game was purchased for.
        /// </summary>
        public decimal PurchAmt;
        /// <summary>
        /// Date game was purchased on.
        /// </summary>
        public DateTime PurchDate;
        /// <summary>
        /// Location purchase took place at.
        /// </summary>
        public string PurchLoc;
        /// <summary>
        /// Initial release date of the game.
        /// </summary>
        public DateTime ReleaseDate;
        /// <summary>
        /// Original retail amount game released for.
        /// </summary>
        public decimal RetailAmt;
        /// <summary>
        /// Title of the game.
        /// </summary>
        public string Title;
        /// <summary>
        /// UPC from the back of the game.
        /// </summary>
        public string UPC;
    }
}
