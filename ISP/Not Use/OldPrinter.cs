namespace ISP.Not_Use
{
    // Problem: OldPrinter doesn’t need Scan or Fax, but must implement.
    public class OldPrinter : IMultiFunctionDevice
    {
        public void Fax( )
        {
            throw new NotImplementedException();
        }

        public void Print( )
        {
            Console.WriteLine("List Printing...");
        }

        public void Scan( )
        {
            throw new NotImplementedException();
        }
    }
}
