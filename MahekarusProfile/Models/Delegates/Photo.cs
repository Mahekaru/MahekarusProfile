using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MahekarusProfile.Models.Delegates
{
    public class Photo
    {
        public string PhotoMessage { get; set; }

        public static Photo Load(string Path)
        {
            var p = new Photo();
            p.PhotoMessage = "Creating and returning Photo Class";
            return p;
        }

        public static void Save()
        {

        }
    }
}