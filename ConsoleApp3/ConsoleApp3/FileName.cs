using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class FileName
    {
        class Kvadrat
        {
            private float a;
            public float Stranica
            {
                get { return a; }
                set { a = value; }
            }


            public Kvadrat() { a = 2.76f; }
            public  double Obim() { return a *= 4; }

            public double Povrsina()
            {
                return Math.Pow(a, 2);
            }
        }
    }
}
