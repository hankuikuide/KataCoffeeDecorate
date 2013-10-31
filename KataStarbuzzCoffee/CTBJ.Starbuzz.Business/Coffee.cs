using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTBJ.Starbuzz.Business
{
    public class Coffee:AbstractProduct
    {

        public Coffee()
        {
            base.name ="Coffee";
            base.price = 22;
        }

    }
}
