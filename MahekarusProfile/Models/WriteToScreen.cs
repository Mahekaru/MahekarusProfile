using System;
using System.Collections.Generic;
using MahekarusProfile.Models.Method_Overriding;
using MahekarusProfile.Models.Delegates;
using System.Linq;
using System.Web;

namespace MahekarusProfile.Models.Access_Modifier
{
    public class WriteToScreen
    {
        public string TextAreaBody { get; set; }
        public string TAB;
        private string _NewLine = "\n";

        //&#13;&#10;
        public void AccessModifierMain()
        {
            var Customer = new Customer();
            var GoldCustomer = new GoldCustomer();
            var RateCalculator = new RateCalculator();

            TextAreaBody = "";
            TextAreaBody = "Application Start!";
            TextAreaBody += _NewLine;

            TextAreaBody = Customer.Promote(TextAreaBody);
            TextAreaBody += _NewLine;
            TextAreaBody = GoldCustomer.OfferVouchar(TextAreaBody);
            TextAreaBody += _NewLine;
            TextAreaBody = RateCalculator.Calculate(Customer, TextAreaBody);

        }

        public void MethodOverridingMain()
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle { Name = "Circle" });
            shapes.Add(new Rectangle { Name = "Rectangle" });
            shapes.Add(new Triangle { Name = "Triangle" });

            var canvas = new Canvas();
            TextAreaBody = "Application Start!";
            TextAreaBody += _NewLine;

            TextAreaBody += "Calling the Canvas Class";
            TextAreaBody += _NewLine;
            TextAreaBody = canvas.DrawShapes(shapes,TextAreaBody);

        
        }

        public string[] Filter { get; set; }
        public void Delegates()
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            PhotoProcessor.PhotoFilterHandler filterHandler = filters.AppllyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            TAB = "";
            processor.Process("photo.jpg", filterHandler,ref TAB);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            photo.TAB += "Apply Remove RedEye";
            //Console.WriteLine("Apply RemoveRedEye");
        }
    }
}