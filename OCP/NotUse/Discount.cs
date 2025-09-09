using Comman.Models;

namespace OCP.NotUse
{
    public class Discount
    { 
        public double CalculateDiscount(Customer customer,double price)
        {
            if(customer.Type == "Regular")
            {
                return price * 0.9; // 90% of the price
            }
            if(customer.Type == "VIP")
            {
                return price * 0.8; // 80% of the price
            }
            return price;
        }
    }
}
