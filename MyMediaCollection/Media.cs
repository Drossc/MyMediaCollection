using System;

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
        /// Description the media.
        /// </summary>
        public string Description;
        /// <summary>
        /// Identifies if purchase was digital.
        /// </summary>
        public bool Digital;
        /// <summary>
        /// Difference between Retail Amount and Purchase Amount.
        /// </summary>
        public string Discount;
        /// <summary>
        /// Amount media was purchased for.
        /// </summary>
        public decimal PurchAmt;
        /// <summary>
        /// Date media was purchased on.
        /// </summary>
        public DateTime PurchDate;
        /// <summary>
        /// Location purchase took place at.
        /// </summary>
        public string PurchLoc;
        /// <summary>
        /// Initial release date of the media.
        /// </summary>
        public DateTime ReleaseDate;
        /// <summary>
        /// Original retail amount media released for.
        /// </summary>
        public decimal RetailAmt;
        /// <summary>
        /// Title of the media.
        /// </summary>
        public string Title;
        /// <summary>
        /// UPC from the back of the media.
        /// </summary>
        public string UPC;
        /// <summary>
        /// Genre indicated for the media.
        /// </summary>
        public string Genre;
    }
}
