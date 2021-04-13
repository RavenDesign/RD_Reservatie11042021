using System;
using System.Collections.Generic;
using System.Text;

namespace RD_Reservatie11042021.library.Managment_side
{
    public class Modules_Extra
    {
        public int id { get; set; }
        public string naam { get; set; }
        public Decimal prijs { get; set; }
        public Decimal new_prijs { get; set; }

        public Modules_Extra()
        {

        }

        public Modules_Extra(int _id, string _naam, Decimal _prijs, Decimal _new_prijs)
        {
            this.id = _id;
            this.naam = _naam;
            this.prijs = _prijs;
            this.new_prijs = _new_prijs;
        }
    }
}
