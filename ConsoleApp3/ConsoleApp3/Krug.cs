using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Krug
    {
        float pp;
        public float Poluprecnik { get { return pp; } set { pp = value; } }
        
        public Krug() {
            pp = 2.76f;
        }

        public double Obim() {
            return pp * 2*Math.PI;
        }
        public double Povrsina() {
            return pp*pp*Math.PI;
        }
    }   
}
