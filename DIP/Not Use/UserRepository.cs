namespace DIP.Not_Use
{
    public class UserRepository
    {
        public void Save(string user)
        {
            Console.WriteLine($"[NotUse] Saving user '{user}' in SQL Database ❌");
        }
    }
}
