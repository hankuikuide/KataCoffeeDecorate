using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CTBJ.Starbuzz.Business;

namespace CTBJ.StarBuzz.Test
{
    [TestClass]
    public class CustomerTest
    {
        Customer customer;

        [TestInitialize]
        public void SetUp()
        {
            customer = new Customer();
        }

        #region 第一组测试
        [TestMethod]
        public void buyCoffeeTest()
        {
            Coffee coffee = new Coffee();

            customer.buy(coffee);
            string actual =customer.print() ;
            string expect = "Coffee(22.00) | Total=22.00";

            Assert.AreEqual(expect, actual);

        }

        [TestMethod]
        public void buyPlainTeaTest()
        {

            PlainTea plainTea = new PlainTea();

            customer.buy(plainTea);
            string actual = customer.print();
            string expect = "PlainTea(25.00) | Total=25.00";

            Assert.AreEqual(expect, actual);

        }

        [TestMethod]
        public void buyBeerTest()
        {

            Beer beer = new Beer();

            customer.buy(beer);
            string actual = customer.print();
            string expect = "Beer(18.00) | Total=18.00";

            Assert.AreEqual(expect, actual);

        }

        [TestMethod]
        public void buyCokeTest()
        {

            Coke coke = new Coke();

            customer.buy(coke);
            string actual = customer.print();
            string expect = "Coke(12.00) | Total=12.00";

            Assert.AreEqual(expect, actual);

        } 

        #endregion

        #region 第二组测试
        [TestMethod]
        public void buyCoffeeAndMilk()
        {
            Coffee coffee = new Coffee();
            Milk milk = new Milk();

            customer.buy(coffee);
            customer.buy(milk);

            string actual = customer.print();
            string expect = "Coffee(22.00)+Milk(3.50) | Total=25.50";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void buyBlackTeaAndHoney()
        {
            BlackTea blackTea = new BlackTea();
            Honey honey = new Honey();

            customer.buy(blackTea);
            customer.buy(honey);

            string actual = customer.print();
            string expect = "BlackTea(25.00)+Honey(4.50) | Total=29.50";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void buyBeerAndLemon()
        {
            Beer beer = new Beer();
            Lemon lemon = new Lemon();

            customer.buy(beer);
            customer.buy(lemon);

            string actual = customer.print();
            string expect = "Beer(18.00)+Lemon(5.00) | Total=23.00";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void buyCokeAndLemon()
        {
            Coke coke = new Coke();
            Lemon lemon = new Lemon();

            customer.buy(coke);
            customer.buy(lemon);

            string actual = customer.print();
            string expect = "Coke(12.00)+Lemon(5.00) | Total=17.00";

            Assert.AreEqual(expect, actual);
        } 
        #endregion

        #region 第三组测试
        [TestMethod]
        public void buyCoffeeAndHoneyAndMilkTest()
        {
            Coffee coffee = new Coffee();
            Honey honey = new Honey();
            Milk milk = new Milk();

            customer.buy(coffee);
            customer.buy(honey);
            customer.buy(milk);


            string actual = customer.print();
            string expect = "Coffee(22.00)+Honey(4.50)+Milk(3.50) | Total=30.00";

            Assert.AreEqual(expect, actual);

        }

        [TestMethod]
        public void buyGreenTeaAndHoneyAndMilkAndChocolateTest()
        {
            GreenTea greenTea = new GreenTea();
            Honey honey = new Honey();
            Milk milk = new Milk();
            Chocolate chocolate = new Chocolate();

            customer.buy(greenTea);
            customer.buy(honey);
            customer.buy(milk);
            customer.buy(chocolate);

            string actual = customer.print();
            string expect = "GreenTea(22.00)+Honey(4.50)+Milk(3.50)+Chocolate(7.00) | Total=37.00";

            Assert.AreEqual(expect, actual);

        }

        public void buyCokeAndAllCondimentTest()
        {
            Coke coke = new Coke();
            Milk milk = new Milk();
            Honey honey = new Honey();
            Lemon lemon = new Lemon();
            Chocolate chocolate = new Chocolate();
            Mocha mocha = new Mocha();

            customer.buy(coke);
            customer.buy(milk);
            customer.buy(honey);
            customer.buy(lemon);
            customer.buy(chocolate);
            customer.buy(mocha);

            string actual = customer.print();
            string expect = "Coke(12.00)+Milk(3.50)+Honey(4.50)+Lemon(5.0)+Chocolate(7.00)+ Mocha(8.0) | Total=40.00";

            Assert.AreEqual(expect, actual);

        } 
        #endregion

        #region 第四组测试
        [TestMethod]
        public void buyLoveFeelingsTest()
        {
            LoveFeelings loveFeelings = new LoveFeelings();

            customer.buy(loveFeelings);

            string actual = customer.print();
            string expect = "LoveFeelings(49.00) | Total=49.00";

            Assert.AreEqual(expect, actual);

        }

        [TestMethod]
        public void buyLoveFeelingsAndLemonTest()
        {
            LoveFeelings loveFeelings = new LoveFeelings();
            Lemon lemon = new Lemon();

            customer.buy(loveFeelings);
            customer.buy(lemon);

            string actual = customer.print();
            string expect = "LoveFeelings(49.00)+Lemon(5.00*80%) | Total=53.00";

            Assert.AreEqual(expect, actual);

        }

        [TestMethod]
        public void buyLoveFeelingsAndAllOfCondimentTest()
        {
            LoveFeelings loveFeelings = new LoveFeelings();
            Honey honey = new Honey();
            Milk milk = new Milk();
            Chocolate chocolate = new Chocolate();
            Mocha mocha = new Mocha();
            Lemon lemon = new Lemon();


            customer.buy(loveFeelings);
            customer.buy(honey);
            customer.buy(milk);
            customer.buy(chocolate);
            customer.buy(mocha);
            customer.buy(lemon);

            string actual = customer.print();
            string expect = "LoveFeelings(49.00)+Honey(4.50*80%)+Milk(3.50*80%)+Chocolate(7.00*80%)+Mocha(8.00*80%)+Lemon(5.00*80%) | Total=71.40";

            Assert.AreEqual(expect, actual);

        }

        #endregion

        #region 第五组测试

        [TestMethod]
        public void buyBeerAndLoversEmbraceTest()
        {
            Beer beer = new Beer();
            LoversEmbrace loversEmbrace = new LoversEmbrace();

            customer.buy(beer);
            customer.buy(loversEmbrace);


            string actual = customer.print();
            string expect = "Beer(18.00)+LoversEmbrace(21.00*80%) | Total=34.80";

            Assert.AreEqual(expect, actual);

        }

        [TestMethod]
        public void buyLoveFeelingsAndLoversEmbraceTest()
        {
            LoveFeelings loveFeelings = new LoveFeelings();
            LoversEmbrace loversEmbrace = new LoversEmbrace();

            customer.buy(loveFeelings);
            customer.buy(loversEmbrace);

            string actual = customer.print();
            string expect = "LoveFeelings(49.00)+LoversEmbrace(21.00*50%) | Total=59.50";

            Assert.AreEqual(expect, actual);

        }

        [TestMethod]
        public void buyLoveFeelingsAndLoversEmbraceAndLemonTest()
        {
            LoveFeelings loveFeelings = new LoveFeelings();
            Lemon lemon = new Lemon();
            LoversEmbrace loversEmbrace = new LoversEmbrace();

            customer.buy(loveFeelings);
            customer.buy(lemon);
            customer.buy(loversEmbrace);

            string actual = customer.print();
            string expect = "LoveFeelings(49.00)+Lemon(5.00*80%)+LoversEmbrace(21.00*50%) | Total=63.50";

            Assert.AreEqual(expect, actual);

        } 


        #endregion

        #region 第六组测试
        [TestMethod]
        public void buyCoffeeAndSugarTest()
        {
            Coffee coffee = new Coffee();
            Sugar sugar = new Sugar();

            customer.buy(coffee);
            customer.buy(sugar);


            string actual = customer.print();
            string expect = "Coffee(22.00)+Sugar(1.00) | Total=23.00";

            Assert.AreEqual(expect, actual);

        }

        [TestMethod]
        public void buyMilkTest()
        {
            Milk milk = new Milk();

            customer.buy(milk);


            string actual = customer.print();
            string expect = "Milk(3.50) | Total=3.50";

            Assert.AreEqual(expect, actual);

        }

        [TestMethod]
        public void buyLemonAndLoversEmbraceTest()
        {
            Lemon lemon = new Lemon();
            LoversEmbrace loversEmbrace = new LoversEmbrace();

            customer.buy(lemon);
            customer.buy(loversEmbrace);


            string actual = customer.print();
            string expect = "Lemon(5.00)+LoversEmbrace(21.00*80%) | Total=21.80";

            Assert.AreEqual(expect, actual);

        }

        [TestMethod]
        public void buyLoveFeelingsAndLemonAndLoversEmbraceOnFridayTest()
        {
            Boolean isFriday = true;
            LoveFeelings loveFeelings = new LoveFeelings();
            Lemon lemon = new Lemon();
            LoversEmbrace loversEmbrace = new LoversEmbrace();

            customer.buy(loveFeelings);
            customer.buy(lemon);
            customer.buy(loversEmbrace);

            customer.setOrderDiscount(isFriday);

            string actual = customer.print();
            string expect = "LoveFeelings(49.00)+Lemon(5.00*80%)+LoversEmbrace(21.00*50%) | Total=63.50*90%=57.15";

            Assert.AreEqual(expect, actual);

        } 

        #endregion
    }
}
