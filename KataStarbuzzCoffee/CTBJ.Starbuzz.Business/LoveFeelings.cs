using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTBJ.Starbuzz.Business
{
    public class LoveFeelings:AbstractProduct
    {
        public LoveFeelings()
        {
            base.name = "LoveFeelings";
            base.price = 49;
            base.newArrival = true;
        }
    }
}
