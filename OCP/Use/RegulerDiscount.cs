namespace OCP.Use
{
    public class RegulerDiscount : IDiscount
    {
        public double Apply(double price)
        {
            return price * 0.7; // 70% of the price
        }
    }
}
