using System;
using System.Collections.Generic;
using System.Text;
using RD_Reservatie11042021.library.Managment_side.Statics;

namespace RD_Reservatie11042021.library.Managment_side
{
    public class Financien_RD
    {
        public int id { get; set; }
        List<Facturen_RD> facturen { get; set; }
        Betaalmethode betaalmethode_id { get; set; }
        public string rekeningNr { get; set; }
        public string rekeninghouder { get; set; }
        public string bic_code { get; set; }
        public string domiciliering { get; set; }
        Betaalplan betaalplan_id { get; set; }
        Plan_abonnement plan_id { get; set; }
        List<Modules_Extra> extras { get; set; }


    }
}
