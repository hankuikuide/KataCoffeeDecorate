using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTBJ.Starbuzz.Business
{
    public class Beer:AbstractProduct
    {
        public Beer()
        {
            base.name = "Beer";
            base.price = 18;
        }
    }
}
