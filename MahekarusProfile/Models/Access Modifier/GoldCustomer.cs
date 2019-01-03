using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MahekarusProfile.Models.Access_Modifier
{
    public class GoldCustomer : Customer
    {
        private string _NewLine = "\n";
        public string OfferVouchar(string TextAreaBody)
        {
            var RV = TextAreaBody;
            RV += "#### Gold Customer Class Hit! ####";
            RV += _NewLine;
            RV += "   I'm a derived class from Customer called GoldCustomer!";
            RV += _NewLine;
            RV += "   Offering Voucher to GoldCustomer";
            return RV;
        }
    }
}