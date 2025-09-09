namespace ISP.Use
{
    public class ModernPrinter : IScanner, IFax, IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Print");
        }

        public void Scan()
        {
            Console.WriteLine("Scan");
        }

        public void SendFax()
        {
            Console.WriteLine("SendFax");
        }
    }
}
