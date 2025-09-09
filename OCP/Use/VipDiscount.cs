namespace OCP.Use
{
    public class VipDiscount : IDiscount
    {
        public double Apply(double price)
        {
            return price * 0.9; // 90% of the price
        }
    }
}
