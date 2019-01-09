using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MahekarusProfile.Models.Delegates
{

    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);

        public string Process(string path,PhotoFilterHandler filterHander,string TBH)
        {
            var photo = Photo.Load(path);
            photo.PhotoMessage += "Photo Class Hit \n";
            photo.PhotoMessage += "Photo Class Contains a Delegate Call PhotoFilterHandler \n";
            photo.PhotoMessage += "Processing Filters Using Delegate Now \n";
            filterHander(photo);
            TBH += photo.PhotoMessage;

            return TBH;
        }
    }
}