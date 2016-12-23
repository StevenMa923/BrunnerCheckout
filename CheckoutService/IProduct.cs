using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutService
{
    public interface IProduct
    {
        double unitprice { get; set; }
        double TotalPrice(int number, bool isdiscounted);
    }


   public class Apple: IProduct
    {
        public double unitprice { get; set; }

  

        public double TotalPrice(int applenumber, bool isdiscounted)
        {
            double _totalappleprice = 0;
            if (!isdiscounted) { _totalappleprice = applenumber * unitprice; }
            else _totalappleprice = Convert.ToDouble((((int)(applenumber / 2)) + (applenumber % 2))) * unitprice;

            return _totalappleprice;
        }    
    }

    public class Orange: IProduct
    {
       public double unitprice { get; set; }
   

       public double TotalPrice(int orangenumber, bool isdiscounted)
       {
           double _totalorangeprice = 0;
          
           if (!isdiscounted) _totalorangeprice = orangenumber * unitprice;
           else _totalorangeprice = Convert.ToDouble((((int)(orangenumber / 3 * 2)) + (orangenumber % 3))) * unitprice;

           return _totalorangeprice;
       }
    }


}
