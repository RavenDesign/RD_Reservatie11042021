using System;
using System.Collections.Generic;
using System.Text;

namespace RD_Reservatie11042021.library.Managment_side
{
    public class Adressen
    {
        public int id { get; set; }
        public string straat { get; set; }
        public string nr { get; set; }
        public string bijvoegsel { get; set; }
        public string postcode { get; set; }
        public string gemeente { get; set; }
        public string land { get; set; }
    }
}
