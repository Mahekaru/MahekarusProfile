using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MahekarusProfile.Models.Delegates
{
    public class PhotoFilters
    {
        public void AppllyBrightness(Photo photo)
        {
            //photo.TAB += "Apply Brightness";
            photo.PhotoMessage += "Apply Brightness \n";
            //textAreaBody += "Apply Brightness";
            //Console.WriteLine("Apply Brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            //photo.TAB += "Apply Contrast";

            photo.PhotoMessage += "Apply Contrast \n";
            //return "Apply Contrast";
            // textAreaBody += "Apply Contrast";
            //Console.WriteLine("Apply contrast");
        }

        public void Resize(Photo photo)
        {
            photo.PhotoMessage += "Resize Photo \n";
            //return "Resize Photo";
            //photo.TAB += "Resize Photo";
            //textAreaBody += "Resize Photo";
            //Console.WriteLine("Resize Photo");
        }

    }
}