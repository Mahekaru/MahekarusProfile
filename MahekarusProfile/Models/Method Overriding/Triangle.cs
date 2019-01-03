using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MahekarusProfile.Models.Method_Overriding
{
    public class Triangle:Shape
    {
        public override string Draw(string TextAreaBody)
        {
            TextAreaBody += "#### Triangle Class Hit! #### \n";
            TextAreaBody += " This is a override method in the Triangle Class \n";
            TextAreaBody += " Draw a Triangle \n";
            return TextAreaBody;
            //Console.WriteLine("#### Triangle Class Hit! ####");
            //Console.WriteLine(" This is a override method in the Triangle Class");
            //Console.WriteLine(" Draw a Triangle");
        }
    }
}