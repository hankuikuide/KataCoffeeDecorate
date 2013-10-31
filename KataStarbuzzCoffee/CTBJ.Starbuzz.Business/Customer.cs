using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTBJ.Starbuzz.Business
{
    public class Customer
    {
        private double totalPrice = 0;

        private List<AbstractProduct> orders = new List<AbstractProduct>();

        private CondimentDiscount discount = CondimentDiscount.DISABLED;

        private Boolean orderDiscount;

        public void setOrderDiscount(Boolean enabled)
        {
            orderDiscount = enabled;
        }

        public void buy(AbstractProduct product)
        {
            orders.Add(product);

            if (product.NewArrival && product.getProductType() == ProductType.BEVERAGE)
            {
                discount = CondimentDiscount.ENABLED;
            }

            totalPrice += product.getPrice(discount);

        }

        public string print()
        {
            string msg = string.Empty;

            foreach (var item in orders)
            {
                msg += item.print(discount) + "+";
            }

            msg = msg.Substring(0, msg.Length - 1) + " | Total=" + totalPrice.ToString("#0.00");

            if (orderDiscount)
            {
                msg += "*90%";
                totalPrice *= 0.9;
                msg += "=" + totalPrice.ToString("#0.00");
            }

            return msg;

        }

    }
}
