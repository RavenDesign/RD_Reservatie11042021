using System;
using System.Collections.Generic;
using System.Text;
using RD_Reservatie11042021.library.User_side;
using RD_Reservatie11042021.library.Managment_side;
using RD_Reservatie11042021.library.Managment_side.Statics;

namespace RD_Reservatie11042021.library.User_side
{
    public class Leden
    {
        public int id { get; set; }
        User_type userType_id { get; set; }
        public string naam { get; set; }
        public string email { get; set; }
        List<Functie> functies { get; set; }
        public string gebruikersnaam { get; set; }
        public string wachtwoord { get; set; }
        public string mac_adress { get; set; }
        public string tel { get; set; }
        public string gsm { get; set; }
        Member_status member_huidigeStatus { get; set; }


    }
}
