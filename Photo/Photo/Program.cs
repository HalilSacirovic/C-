using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PhotoProcessor phprocesor = new PhotoProcessor();   
            PhotoFilter phfilter = new PhotoFilter();
            PhotoProcessor.PhotoFilterHandler phfilterHandler = PhotoFilter.ApplyBrightness;
            phfilterHandler += RedEyeFilter;

            phprocesor.Proccess("https://dunp.ac.rs/images/nature.png", phfilterHandler);
            Console.ReadLine();
        }

        public static void RedEyeFilter(Photo photo)
        {
            Console.WriteLine($"On photo {photo.Title} we apply removing red eye filter!");
        }
    }
}
