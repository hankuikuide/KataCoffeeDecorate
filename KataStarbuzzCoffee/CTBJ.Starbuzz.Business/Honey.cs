using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTBJ.Starbuzz.Business
{
    public class Honey:AbstractProduct
    {
        public Honey()
        {
            base.name = "Honey";
            base.price = 4.5;
            base.productType = ProductType.CONDIMENT;

        }
    }
}
