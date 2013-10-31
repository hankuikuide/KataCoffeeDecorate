using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTBJ.Starbuzz.Business
{
    public  class GreenTea:AbstractProduct
    {
        public GreenTea()
        {
            base.name = "GreenTea";
            base.price=22;
        }
    }
}
