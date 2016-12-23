using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckoutService;
using System.Collections.Generic;

namespace CheckSystemUnitTest
{
    [TestClass]
    public class CheckOutTest
    {
        [TestMethod]
        public void CheckOutTotalPriceTest1()
        {   
            List<IProduct> productlist = new List<IProduct>()
            {
                new Apple(),
                new Apple(),
                new Apple(),
                new Orange(),
                new Orange(),
                new Orange(),
                new Orange(),
                new Orange(),
            };
            var testresult = new Checkout().GetTotalPrice(productlist,true, true);
            Assert.AreEqual(3.5, testresult);
        }

        [TestMethod]
        public void CheckOutTotalPriceTest2()
        {
            List<IProduct> productlist = new List<IProduct>()
            {
                new Apple(),
                new Apple(),
                new Apple(),
                new Orange(),
                new Orange(),
                new Orange(),
                new Orange(),
                new Orange(),
            };
            var testresult = new Checkout().GetTotalPrice(productlist, false, false);
            Assert.AreEqual(4.6, testresult);

        }

        [TestMethod]
        public void CheckOutTotalPriceTest3()
        {
            List<IProduct> productlist = new List<IProduct>();
   
            var testresult = new Checkout().GetTotalPrice(productlist, false, false);
            Assert.AreEqual(0, testresult);
        }

        [TestMethod]
        public void ApplePriceTest1()
        {  
            Apple apple = new Apple();
            apple.unitprice = 0.45;
            var result = apple.TotalPrice(3, false);
            Assert.AreEqual(1.35, result);
        }

        [TestMethod]
        public void ApplePriceTest2()
        {
            Apple apple = new Apple();
            apple.unitprice = 0.45;
            var result = apple.TotalPrice(3, true);
            Assert.AreEqual(0.9, result);
        }

        
       
        [TestMethod]
        public void OrangePriceTest2()
        {
            Orange orange = new Orange();
            orange.unitprice = 0.65;
            var result = orange.TotalPrice(3, true);
            Assert.AreEqual(1.3, result);
        }


       

    }
}
