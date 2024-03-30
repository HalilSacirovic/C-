using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    abstract class Let
    {
        private string polaznaDestinacija;
        private string dolaznaDestinacija;
        private DateTime datumPoletanja;
        private int brRezervisanihMesta;
        public Let(string polaznaDestinacija, string dolaznaDestinacija, DateTime datumPoletanja, int brRezervisanihMesta)
        {
            this.polaznaDestinacija = polaznaDestinacija;
            this.dolaznaDestinacija = dolaznaDestinacija;
            this.datumPoletanja = datumPoletanja;
            this.brRezervisanihMesta = brRezervisanihMesta;
        }

        public string PolaznaDestinacija
        {
            get { return polaznaDestinacija; }
            set { polaznaDestinacija = value; }
        }

        public string DolaznaDestinacija
        {
            get => dolaznaDestinacija; set { dolaznaDestinacija = value; }
        }

        public int BrRezervisanihMesta
        {
            get { return brRezervisanihMesta; }
            set { brRezervisanihMesta = value; }
        }

        public DateTime DatumPoletanj
        {
            get { return datumPoletanja; }
            set { datumPoletanja = value; }
        
        }

        public abstract bool Rezervacija();  
    }
}
