using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTBJ.Starbuzz.Business
{
    public class PlainTea:AbstractProduct
    {

        public PlainTea()
        {
            base.name = "PlainTea";
            base.price = 25;
        }

    }
}
