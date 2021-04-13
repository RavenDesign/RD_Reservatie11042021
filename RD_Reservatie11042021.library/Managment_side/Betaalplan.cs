using System;
using System.Collections.Generic;
using System.Text;

namespace RD_Reservatie11042021.library.Managment_side
{
    public class Betaalplan
    {
        public int id { get; set; }
        public string naam { get; set; }
        public Decimal korting { get; set; }
        public int maanden { get; set; }
        public DateTime datum_start { get; set; }
        public DateTime datum_einde { get; set; }
        public Boolean hernieuwing_auto { get; set; }
        public Boolean wijziging_boolean { get; set; }
        public string Nieuwe_wijziging_naam { get; set; }


        

        public Betaalplan()
        {

        }

        public Betaalplan(int _id, string _naam, Decimal _korting, int _maanden, DateTime _datum_start, DateTime _datum_einde, Boolean _hernieuwing_auto, Boolean _wijziging_boolean, string _Nieuwe_wijziging_naam)
        {
            this.id = _id; 
            this.naam = _naam;
            this.korting = _korting;
            this.maanden = _maanden;
            this.datum_start = _datum_start;
            this.datum_einde = _datum_einde;
            this.hernieuwing_auto = _hernieuwing_auto;
            this.wijziging_boolean = _wijziging_boolean;
            this.Nieuwe_wijziging_naam = _Nieuwe_wijziging_naam;
        }
    }
}
