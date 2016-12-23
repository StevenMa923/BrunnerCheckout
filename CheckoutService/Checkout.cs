using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutService
{
    public class Checkout
    {   
        public Dictionary<string, double> productPriceDict = new Dictionary<string,double>()
        {
            {"Apple", 0.45},
            {"Orange", 0.65}
        };
          
         //Order ProductList
         public List<IProduct> ProductList = new List<IProduct>();


         private int GetNumber(List<IProduct> productList, IProduct product)
          {
              int number = 0;

              foreach (var p in productList)
              {               
                  if (product.GetType()== p.GetType())
                  {
                      number++;
                  }
              }
              return number;
          }

        //Get Total Product Price
           public double GetTotalPrice(List<IProduct> productList, bool isAppleDiscounted, bool isOrangeDiscounted)
          {
               Apple apple = new Apple();
               Orange orange = new Orange();
               //set unit price for each item
               orange.unitprice= productPriceDict["Orange"];
               apple.unitprice = productPriceDict["Apple"];
               int applenumber = this.GetNumber(productList, new Apple());
               int orangenumber = this.GetNumber(productList, new Orange());
               return apple.TotalPrice(applenumber, isAppleDiscounted) + orange.TotalPrice(orangenumber, isOrangeDiscounted);
          }
    }
}
