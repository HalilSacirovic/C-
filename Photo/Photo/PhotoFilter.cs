using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo
{
    internal class PhotoFilter
    {
        public static void ApplyBrightness(Photo photo)
        {
            Console.WriteLine($"On photo {photo.Title} we apply brightness filter!");
        }

        public static void ApplySmoothing(Photo photo) {
            Console.WriteLine($"On photo{photo.Title} we apply some smoothing filter");
        }
    }
}
