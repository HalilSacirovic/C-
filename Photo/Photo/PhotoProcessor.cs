using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo
{
    internal class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);

        public void Proccess(string url,PhotoFilterHandler photofilterhandler)
        {
            Photo photo = Photo.load(url);
            Console.WriteLine("Base photo has been loaded!");
            photofilterhandler(photo); 
            photo.Save();
        }
    }
}
