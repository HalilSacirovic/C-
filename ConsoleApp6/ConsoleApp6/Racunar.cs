using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Racunar
    {
        private Random R = new Random();
        private int broj;
        public int Broj {  get { return broj; } set { broj = value; } }   

        public Racunar()
        {
            GenBroj();
        }

        public void GenBroj()
        {
            Broj = R.Next(1,10);
        }
    }


}
