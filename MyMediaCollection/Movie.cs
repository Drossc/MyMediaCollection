using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaCollection
{
    public class Movie : Media
    {
        /// <summary>
        /// Flag to indicate if purchase is BluRay.
        /// </summary>
        public bool BluRay;
        /// <summary>
        /// Flag to indicate if purchase is DVD.
        /// </summary>
        public bool Dvd;
        /// <summary>
        /// Flag to indicate if purchase is VHS.
        /// </summary>
        public bool Vhs;
        /// <summary>
        /// MPAA Rating listed for the movie listed.
        /// </summary>
        public string MpaaRating;
    }
}
