using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class CarteLet : Let
    {
        private int brMestaRedovnilet;
        private int brMestaVanrednilet;
        public int BrMestaRedovniLet
        {
            get { return  brMestaRedovnilet; } 
            set
            {
                brMestaRedovnilet = value;
            }
        }
        public int BrMestaVanredniLet
        {
            get { return brMestaVanrednilet; }
            set
            {
                brMestaVanrednilet = value;
            }
        }

        public CarteLet(int brMestaRedovniLet,int brMestaVanrednilet,string polaznaDestinacija, string dolaznaDestinacija, DateTime datumPoletanja, int brRezervisanihMesta) : base(polaznaDestinacija, dolaznaDestinacija, datumPoletanja, brRezervisanihMesta)
        {
            this.brMestaVanrednilet= brMestaRedovniLet;
            this.brMestaRedovnilet= brMestaRedovniLet;
        }

        public override bool Rezervacija()
        {
            if( BrRezervisanihMesta == brMestaRedovnilet + brMestaVanrednilet)
            {
                return false;
            }
            BrRezervisanihMesta++;
            return true;
        }

        public override string ToString()
        {
            return $"Na letu koji ide od {PolaznaDestinacija} do {DolaznaDestinacija}"
                +$"datuma {DatumPoletanj.ToString("dd.MM.yyyy HH:mm:ss")},"
                + $" ima slobodnih mesta {brMestaRedovnilet + brMestaVanrednilet - BrRezervisanihMesta}";
        }
    }
}
