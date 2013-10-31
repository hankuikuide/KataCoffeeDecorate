using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTBJ.Starbuzz.Business
{
    public class BlackTea:AbstractProduct
    {
        public BlackTea()
        {
            base.name = "BlackTea";
            base.price = 25;
        }
    }
}
