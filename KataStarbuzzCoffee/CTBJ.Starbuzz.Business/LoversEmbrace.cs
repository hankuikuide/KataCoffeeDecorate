using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTBJ.Starbuzz.Business
{
    public class LoversEmbrace:AbstractProduct
    {
        public LoversEmbrace()
        {
            base.name = "LoversEmbrace";
            base.price = 21;
            base.productType = ProductType.CONDIMENT;
            base.newArrival = true;
        }
    }
}
