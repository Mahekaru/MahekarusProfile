using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MahekarusProfile.Models;

namespace MahekarusProfile.Controllers.Api
{
    public class BinaryAPIController : ApiController
    {
        
        public string GetData(int id,[FromUri] string value)
        {
            string s = "";

            var b = new ConvertToBinary();

            if (value != null)
            {
                if(id == 1)
                {
                    s = b.ToBinary(value);
                }
                else
                {
                    s = b.ToText(value);
                }
            }
            else
            {
                Console.WriteLine("This is a test");
            }

            return s;
        }
    }
}
