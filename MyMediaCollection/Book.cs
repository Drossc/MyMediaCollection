using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaCollection
{
    public class Book : Media
    {
        /// <summary>
        /// Author of the listed book.
        /// </summary>
        public string Author;
        /// <summary>
        /// Flag to indicate hard back purchase.
        /// </summary>
        public bool HardBack;
        /// <summary>
        /// Flag to indicate physical book purchase.
        /// </summary>
        public bool Physical;
    }
}
