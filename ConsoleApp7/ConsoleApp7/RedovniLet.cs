using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class RedovniLet : Let

    {
        private int brMesta;

        public int BrMesta
        {
            get { return brMesta; }
            set { brMesta = value; }
        }

        public RedovniLet(int brMesta,string polaznaDestinacija, string dolaznaDestinacija, DateTime datumPoletanja, int brRezervisanihMesta) : base(polaznaDestinacija, dolaznaDestinacija, datumPoletanja, brRezervisanihMesta)
        {
            this.brMesta = brMesta;
        }

        public  override bool Rezervacija()
        {
           if (BrRezervisanihMesta == BrMesta)
            {
                return false;
            }
            BrRezervisanihMesta++;
            return true;    
        }

        public override string ToString()
        {
            return $"Na letu koji polazi od {PolaznaDestinacija}  do {DolaznaDestinacija},datuma {DatumPoletanj.ToString("dd.MM.yyyy HH:mm:ss")},ima slobodnih mesta {brMesta-BrRezervisanihMesta}";
        }
    }
}
