using System;
using System.Collections.Generic;
using System.Text;

namespace _06.StoreBoxes
{
    class Box
    {
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuanity {get; set; }
        public double PriceForBox { get; set; }
    }
}
