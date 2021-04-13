using System;
using System.Collections.Generic;
using System.Text;

namespace RD_Reservatie11042021.library.Managment_side.Statics
{
    public class Functie
    {
        public int id { get; set; }
        public string naam { get; set; }
        public Boolean volledig_beheer { get; set; }
        public Boolean beheer_second_Line { get; set; }
        public Boolean verantw_algm { get; set; }
        public Boolean verantw_RM { get; set; }
        public Boolean verantw_HM { get; set; }
        public Boolean verantw_EM { get; set; }
        public Boolean verantw_TM { get; set; }
        public Boolean pers_algm { get; set; }
        public Boolean pers_RM { get; set; }
        public Boolean pers_HM { get; set; }
        public Boolean pers_EM { get; set; }
        public Boolean pers_TM { get; set; }


        public Functie()
        {

        }

        public Functie (int _id, string _naam, Boolean _volledig_beheer, Boolean _beheer_second_Line, Boolean _verantw_algm, Boolean _verantw_RM, Boolean _verantw_HM, Boolean _verantw_EM, Boolean _verantw_TM, Boolean _pers_algm, Boolean _pers_RM, Boolean _pers_HM, Boolean _pers_EM, Boolean _pers_TM)
        {
            this.id = _id;
            this.naam = _naam;
            this.volledig_beheer = _volledig_beheer;
            this.beheer_second_Line = _beheer_second_Line;
            this.verantw_algm = _verantw_algm;
            this.verantw_RM = _verantw_RM;
            this.verantw_HM = _verantw_HM;
            this.verantw_EM = _verantw_EM;
            this.verantw_TM = _verantw_TM;
            this.pers_algm = _pers_algm;
            this.pers_RM = _pers_RM;
            this.pers_HM = _pers_HM;
            this.pers_EM = _pers_EM;
            this.pers_TM = _pers_TM;
        }
    }
}
