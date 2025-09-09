namespace OCP.Use
{
    public class DiscountManager
    {
        public double CalculateDiscount(IDiscount discountStrategy, double price)
        {
            return discountStrategy.Apply(price);
        }
    }
}
