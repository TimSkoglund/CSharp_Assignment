using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Console.Main.App
{
    internal class Contact
    {
        public Contact(string förNamn, string efterNamn, string Email, String Telefon, String Address, String Stad, ) 
        {
            förNamn = förNamn;
            efterNamn = efterNamn;
            Email = Email;
            Telefon = Telefon;
            Address = Address
            Stad = Stad;

        }
        public string förNamn { get; set; }
        public string efterNamn { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Address { get; set; }

        public string Stad { get; set; }
   
    }
}
