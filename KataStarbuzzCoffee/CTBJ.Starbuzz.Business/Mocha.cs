using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTBJ.Starbuzz.Business
{
    public class Mocha:AbstractProduct
    {
        public Mocha()
        {
            base.name = "Mocha";
            base.price= 8;
            base.productType = ProductType.CONDIMENT;

        }
    }
}
