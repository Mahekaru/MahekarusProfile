using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MahekarusProfile.Models;

namespace MahekarusProfile.Controllers
{
    public class BinaryConverterController : Controller
    {
        // GET: TextToHex
        public ActionResult Index()
        {
            return View(new clsConvertToBin());
        }

        //[HttpPost]
        //public ActionResult h(string textAnswer)
        //{

        //    return View();
        //}

        public ActionResult Test()
        {
            return View();
        }


        public ActionResult ToBinary(string myText, string myBinary, string submit)
        {
            var ConvertToBinary = new clsConvertToBin();
            ConvertToBinary.animate = "showMe";
            if (submit == "to Binary")
            {
                ConvertToBinary.Binary = ConvertToBinary.ToBinary(myText);
            }
            else
            {
                ConvertToBinary.text = ConvertToBinary.ToText(ConvertToBinary.SanitizeInput(myBinary)).ToString();
            }



            return View("Index", ConvertToBinary);

        }
    }
}