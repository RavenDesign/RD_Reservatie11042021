using System;
using System.Collections.Generic;
using System.Text;

namespace RD_Reservatie11042021.library.Managment_side
{
    public class Plan_abonnement
    {
        public int id { get; set; }
        
        // Boolean word geactiveerd indien deze deel is van het plan.
        public Boolean RM { get; set; }
        public Boolean EM { get; set; }
        public Boolean HM { get; set; }
        public Boolean TM { get; set; }
        
        // Huidige toepasbare prijs van het abonnement.
        public Decimal prijs_RM { get; set; }
        public Decimal prijs_EM { get; set; }
        public Decimal prijs_HM { get; set; }
        public Decimal prijs_TM { get; set; }

        // Nieuwe prijs als de prijzen veranderen - word toegepast zodra het abonnement vernieuwd, afhankelijk van welk termijn.
        public Decimal new_prijs_RM { get; set; }
        public Decimal new_prijs_EM { get; set; }
        public Decimal new_prijs_HM { get; set; }
        public Decimal new_prijs_TM { get; set; }


        public Plan_abonnement()
        {

        }

        public Plan_abonnement(int _id, Boolean _RM, Boolean _EM, Boolean _HM, Boolean _TM, Decimal _prijs_RM, Decimal _prijs_EM, Decimal _prijs_HM, Decimal _prijs_TM, Decimal _new_prijs_RM, Decimal _new_prijs_EM, Decimal _new_prijs_HM, Decimal _new_prijs_TM)
        {
            this.id = _id;

            this.RM = _RM;
            this.EM = _EM;
            this.HM = _HM;
            this.TM = _TM;

            this.prijs_RM = _prijs_RM;
            this.prijs_EM = _prijs_EM;
            this.prijs_HM = _prijs_HM;
            this.prijs_TM = _prijs_TM;

            this.new_prijs_RM = _new_prijs_RM;
            this.new_prijs_EM = _new_prijs_EM;
            this.new_prijs_HM = _new_prijs_HM;
            this.new_prijs_TM = _new_prijs_TM;

    }
    }
}
