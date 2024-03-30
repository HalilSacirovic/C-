using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp7
{
    internal class AvioKompanija
    {
        private Let[] letovi;
        private int maxLetova;
        private int brLetova;
        public Let[] Letovi
        {
            get { return letovi; }
            set { letovi = value; }
        }
        public int BrLetova
        {
            get => brLetova;
            set { brLetova = value; }
        }

        public AvioKompanija(int maxLetova)
        {
           this.maxLetova = maxLetova;
            letovi = new Let[maxLetova]; 
            brLetova=0;
        }

        public void DodajLet(Let l)
        {
            if (brLetova == maxLetova)
            {
                return;
            }
            if (l is CarteLet)
            {
                var temp = l as CarteLet;
                letovi[brLetova] = new CarteLet(temp.BrMestaRedovniLet,temp.BrMestaVanredniLet,temp.PolaznaDestinacija,temp.DolaznaDestinacija,temp.DatumPoletanj,temp.BrRezervisanihMesta);
            }
            else
            {
                var temp = l as RedovniLet;
                letovi[brLetova++] = new RedovniLet(temp.BrMesta, temp.PolaznaDestinacija, temp.DolaznaDestinacija, temp.DatumPoletanj, temp.BrRezervisanihMesta);
            } 

        }

        public void RezervisiKartu(string polaznaDestinacija,
             string dolaznaDestinacija, DateTime vremePoletanja)
        {
            for (int i = 0; i < brLetova; i++)
            {
                if (letovi[i].PolaznaDestinacija == polaznaDestinacija &&
                    letovi[i].DolaznaDestinacija == dolaznaDestinacija &&
                    letovi[i].DatumPoletanj == vremePoletanja)
                {
                    if (letovi[i].Rezervacija() == true)
                        return;
                }
            }
        }
        public void PoredjajPoVremenu()
        {
            for (int i = 0; i < brLetova - 1; i++)
                for (int j = i + 1; j < brLetova; j++)
                    if (letovi[i].DatumPoletanj > letovi[j].DatumPoletanj)
                    {
                        var pom = letovi[i];
                        letovi[i] = letovi[j];
                        letovi[j] = pom;
                    }
        }


        public override string ToString()
        {
            string tekst = "";
            for (int i = 0; i < brLetova; i++)
                tekst += letovi[i].ToString() + Environment.NewLine;
            return tekst;
        }
    }
}
