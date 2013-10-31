using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTBJ.Starbuzz.Business
{
    public class Sugar:AbstractProduct
    {
        public Sugar()
        {
            base.name = "Sugar";
            base.price = 1;
            base.productType = ProductType.CONDIMENT;

        }
    }
}
