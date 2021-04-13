using System;
using System.Collections.Generic;
using System.Text;

namespace RD_Reservatie11042021.library.Managment_side.Statics
{
    public class User_type
    {
        public int id { get; set; }
        public string naam { get; set; }


        public User_type()
        {

        }

        public User_type(int _id, string _naam)
        {
            this.id = _id;
            this.naam = _naam;

            // Data to be entered on creation database
                // Persoonlijk account (individueel gebruik)
                    // Data to use: Naam, tel, gsm, email, Username, wacthwoord.
                // Personeel account (algemeen account voor personeel)
                    // Data to use: Naam, username, wachtwoord.
                // Workstation account (Account gelinkt aan werkstation)
                    // Data to use: Naam, mac-adress
        }
    }
}
