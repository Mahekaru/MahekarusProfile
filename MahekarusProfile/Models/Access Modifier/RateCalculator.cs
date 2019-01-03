using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MahekarusProfile.Models.Access_Modifier
{
    internal class RateCalculator
    {
        private string _NewLine = "\n";
        public string Calculate(Customer customer,string TextAreaBody)
        {
            var RV = TextAreaBody;

            RV += "#### RateCalculator Class Hit ####";
            RV += _NewLine;
            RV += "   I'm an internal class called RateCalculator";
            RV += _NewLine;
            RV += "   I use customer as an argument, and calculate Rates.";

            return RV;
        }
    }
}