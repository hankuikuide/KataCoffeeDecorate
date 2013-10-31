using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTBJ.Starbuzz.Business
{
    public class Milk:AbstractProduct
    {
        public Milk()
        {
            base.name = "Milk";
            base.price = 3.5;
            base.productType = ProductType.CONDIMENT;

        }
    }
}
