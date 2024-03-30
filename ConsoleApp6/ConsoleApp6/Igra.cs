using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Igra
    {
        Igrac  igrac = new Igrac();
        Racunar racunar = new Racunar();  
        public void Igraj()
        {
            int brPogodaka = 0,brGenerisanja = 0;
            
            while(true)
            {
                igrac.GenBroj();
                if(igrac.Broj == -1)
                {
                    break;
                }
                racunar.GenBroj();
                if(igrac.Broj == racunar.Broj)
                {
                    brPogodaka ++;
                }
               brGenerisanja ++;
            }

            float procenat = (float)brPogodaka / brGenerisanja;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Igrac {igrac.Ime} je pogodio {brPogodaka} puta i ostvario uspesnost od {procenat} ");

        }
    }
}
