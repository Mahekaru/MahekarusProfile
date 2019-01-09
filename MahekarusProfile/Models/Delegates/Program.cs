using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MahekarusProfile.Models.Delegates
{
    public class Program
    {
        public string[] Filter { get; set; }

        public static void Main(string[] args)
        {
            //var processor = new PhotoProcessor();
            //var filters = new PhotoFilters();
            
            //PhotoProcessor.PhotoFilterHandler filterHandler = filters.AppllyBrightness;
            //filterHandler += filters.ApplyContrast;
            //filterHandler += RemoveRedEyeFilter;

            
            //processor.Process("photo.jpg",filterHandler);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye \n");
        }
    }
}