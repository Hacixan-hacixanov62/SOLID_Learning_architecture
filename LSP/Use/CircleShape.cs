namespace LSP.Use
{
    public class CircleShape:IShape
    {
        public double Radius { get; set; }
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
