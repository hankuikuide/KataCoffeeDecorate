using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTBJ.Starbuzz.Business
{
    public class Lemon:AbstractProduct
    {
        public Lemon()
        {
            base.name = "Lemon";
            base.price = 5;
            base.productType = ProductType.CONDIMENT;

        }
    }
}
