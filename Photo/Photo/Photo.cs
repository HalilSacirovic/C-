using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo
{
    internal class Photo
    {

        private string title;

        public Photo()
        {

            title = "Nature";
        }

        public  static Photo load(string url)
        {
            return new Photo();
        }

        public void Save()
        {
            Console.WriteLine("Modified photo has been saved");
        }
        public string Title { get { return title; } set { title = value; } }

        
    }
}
