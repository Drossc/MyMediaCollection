using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaCollection
{
    public class Album : Media
    {
        /// <summary>
        /// Flag to inidcate if purchase on cassette.
        /// </summary>
        public bool Cassette;
        /// <summary>
        /// Flag to indicate if purchase on CD.
        /// </summary>
        public bool CD;
        /// <summary>
        /// Flag to indicate Explicit Language.
        /// </summary>
        public bool RiaaPal;
        /// <summary>
        /// Flag to indicate if purchase on Vinyl.
        /// </summary>
        public bool Vinyl;
    }
}
