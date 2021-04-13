using System;
using System.Collections.Generic;
using System.Text;

namespace RD_Reservatie11042021.library.Managment_side.Statics
{
    public class Betaalmethode
    {
        public int id { get; set; }
        public string naam { get; set; }
        public string land { get; set; }

        public Betaalmethode()
        {

        }

        public Betaalmethode(int _id, string _naam, string _land)
        {
            this.id = _id;
            this.naam = _naam;
            this.land = _land;
        }
    }
}
