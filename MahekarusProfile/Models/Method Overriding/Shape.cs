using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MahekarusProfile.Models.Method_Overriding
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }
        //public Position Position { get; set; }
        //public ShapeType Type { get; set; }.

        public virtual string Draw(string TextAreaBody)
        {
            TextAreaBody += "#### Shape Class Hit! #### \n";
            TextAreaBody += " This is a virtual draw method in the Shape class \n";
            return TextAreaBody;
            //Console.WriteLine("#### Shape Class Hit! #### \n");
            //Console.WriteLine(" This is a virtual draw method in the Shape class");
        }
    }
}