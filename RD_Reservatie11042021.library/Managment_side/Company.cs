using System;
using System.Collections.Generic;
using RD_Reservatie11042021.library.User_side;
using RD_Reservatie11042021.library.Managment_side;
using RD_Reservatie11042021.library.Managment_side.Statics;

namespace RD_Reservatie11042021.library.Managment_side
{
    public class Company
    {
        public int id { get; set; }
        public List<Leden> leden_list { get; set; }
        public string btwNr { get; set; }
        public string kvkNr { get; set; }
        public string algm_email { get; set; }
        public string fact_email { get; set; }
        public string tel { get; set; }
        public string gsm { get; set; }
        public Adressen domiAdress_id { get; set; }
        public Adressen factAdress_id { get; set; }
        public RM RM_id { get; set; }
        public HM HM_id { get; set; }
        public EM EM_id { get; set; }
        public TM TM_id { get; set; }
        public Financien_RD data_financien { get; set; }
        public Comp_status status { get; set; }




    }
}
