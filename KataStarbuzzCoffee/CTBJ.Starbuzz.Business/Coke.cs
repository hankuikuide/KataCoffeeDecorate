using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTBJ.Starbuzz.Business
{
    public class Coke:AbstractProduct
    {
        public Coke()
        {
            base.name = "Coke";
            base.price = 12;
        }
    }
}
