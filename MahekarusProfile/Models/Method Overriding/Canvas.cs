using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MahekarusProfile.Models.Method_Overriding
{
    public class Canvas
    {
        public string DrawShapes(List<Shape> shapes,string TextAreaBody)
        {

            foreach (var shape in shapes)
            {
                TextAreaBody += "#### Canvas Class Hit! #### \n";
                TextAreaBody += " Calling the Virtual Draw method found in the shape class \n";
                TextAreaBody += " Calling " + shape.Name + "\n";
                //Console.WriteLine("#### Canvas Class Hit! ####");
                //Console.WriteLine(" Calling the Virtual Draw method found in the shape class");
                //Console.WriteLine(" Calling " + shape.Name);
                TextAreaBody = shape.Draw(TextAreaBody);
            }
            return TextAreaBody;
        }
    }
}