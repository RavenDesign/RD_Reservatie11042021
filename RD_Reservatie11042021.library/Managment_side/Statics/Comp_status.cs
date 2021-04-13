using System;
using System.Collections.Generic;
using System.Text;

namespace RD_Reservatie11042021.library.Managment_side.Statics
{
    public class Comp_status
    {
        public int id { get; set; }
        public string naam { get; set; }

        public Comp_status()
        {

        }

        public Comp_status(int _id, string _naam)
        {
            this.id = _id;
            this.naam = _naam;
        }
    }
}
