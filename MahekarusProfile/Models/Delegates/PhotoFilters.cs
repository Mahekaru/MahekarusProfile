using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MahekarusProfile.Models.Delegates
{
    public class PhotoFilters
    {
        public string AppllyBrightness(Photo photo)
        {
            //photo.TAB += "Apply Brightness";
            return "Apply Brightness";
            //textAreaBody += "Apply Brightness";
            //Console.WriteLine("Apply Brightness");
        }

        public string ApplyContrast(Photo photo)
        {
            //photo.TAB += "Apply Contrast";
            return "Apply Contrast";
            // textAreaBody += "Apply Contrast";
            //Console.WriteLine("Apply contrast");
        }

        public string Resize(Photo photo)
        {
            return "Resize Photo";
            //photo.TAB += "Resize Photo";
            //textAreaBody += "Resize Photo";
            //Console.WriteLine("Resize Photo");
        }

    }
}