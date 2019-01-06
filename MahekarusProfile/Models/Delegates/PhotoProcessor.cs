using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MahekarusProfile.Models.Delegates
{

    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path,PhotoFilterHandler filterHander)
        {
            var photo = Photo.Load(path);
            
            filterHander(photo);
        
        }
    }
}