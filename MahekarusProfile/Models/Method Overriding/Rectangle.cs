using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MahekarusProfile.Models.Method_Overriding
{
    public class Rectangle:Shape
    {
        public override string Draw(string TextAreaBody)
        {
            TextAreaBody += "#### Rectangle Class Hit #### \n";
            TextAreaBody += " This is a override method in the Rectangle Class \n";
            TextAreaBody += " Draw a rectangle \n";
            return TextAreaBody;
            //Console.WriteLine("#### Rectangle Class Hit ####");
            //Console.WriteLine(" This is a override method in the Rectangle Class");
            //Console.WriteLine(" Draw a rectangle");
        }
    }
}