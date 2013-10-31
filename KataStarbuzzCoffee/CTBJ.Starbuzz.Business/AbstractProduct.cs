using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTBJ.Starbuzz.Business
{
    public enum ProductType
    {
        BEVERAGE,
        CONDIMENT
    }
    public enum CondimentDiscount
    {
        ENABLED,
        DISABLED
    }

    public abstract class AbstractProduct
    {
        protected string name;
        protected double price;
        protected ProductType productType;
        protected Boolean newArrival;

        public Boolean NewArrival
        {
            get { return newArrival; }
            private set { newArrival = value; }
        }

        public ProductType getProductType()
        {
            return this.productType;
        }

        public double getPrice(CondimentDiscount discount)
        {

            if (this.productType == ProductType.CONDIMENT)
            {
                if ((discount == CondimentDiscount.ENABLED && this.newArrival))
                {
                    return this.price * 0.5;
                }
                else if (discount == CondimentDiscount.ENABLED || this.newArrival)
                {
                    return this.price * 0.8;
                }
            }

            return this.price;
        }

        public string print(CondimentDiscount discount)
        {

            if (this.productType == ProductType.CONDIMENT)
            {
                if (discount == CondimentDiscount.ENABLED && this.newArrival)
                {
                    return this.name + "(" + this.price.ToString("#0.00") + "*50%)";
                }
                else if (discount == CondimentDiscount.ENABLED || this.newArrival)
                {
                    return this.name + "(" + this.price.ToString("#0.00") + "*80%)";
                }
            }

            return this.name + "(" + this.price.ToString("#0.00") + ")";

        }
    }
}
