using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MahekarusProfile.Models.Method_Overriding
{
    public class Circle:Shape
    {
        public override string Draw(string TextAreaBody)
        {
            //Any code specific to the circle itself
            TextAreaBody += "#### Circle Class Hit #### \n";
            TextAreaBody += " This is a override method in the Circle Class \n";
            TextAreaBody += " Draw a circle \n";
            return TextAreaBody;
            //Console.WriteLine("#### Circle Class Hit ####");
            //Console.WriteLine(" This is a override method in the Circle Class");
            //Console.WriteLine(" Draw a circle");
        }
    }
}