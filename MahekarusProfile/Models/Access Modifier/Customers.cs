using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MahekarusProfile.Models.Access_Modifier
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private string _NewLine = "\n";
        public string Promote(string textAreaBody)
        {
            var RV = textAreaBody;

            var calculator = new RateCalculator();

            RV += "#### Customer Class Hit ####";
            RV += _NewLine;
            RV += "   I use the RateCalculator class to promote customers to GoldCustomer status";
            RV += _NewLine;
            RV += "   Promote logic processed.";
            return RV;
        }


    }
}