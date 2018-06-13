using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Activity14_1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DiscountService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DiscountService.svc or DiscountService.svc.cs at the Solution Explorer and start debugging.
    public class DiscountService : IDiscountService
    {
        public double GetDiscount(string discountCode)
        {
            if (discountCode == "XXXX")
            {
                return 20;
            }
            else
            {
                return 10;
            }
        }
    }
}
