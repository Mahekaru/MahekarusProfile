using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MahekarusProfile.Models.Delegates
{
    public class Photo
    {
        public static Photo Load(string Path)
        {
            var p = new Photo();
            return p;
        }

        public static void Save()
        {

        }
    }
}