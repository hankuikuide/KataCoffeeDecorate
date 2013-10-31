using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTBJ.Starbuzz.Business
{
    public class Chocolate:AbstractProduct
    {
        public Chocolate()
        {
            base.name = "Chocolate";
            base.price = 7;
            base.productType = ProductType.CONDIMENT;
        }
    }
}
