using Comman.Models;

namespace DIP.Use
{
    public class SqlUserRepository : IUserRepository
    {
        public void Save(string username)
        {
            Console.WriteLine($"[Use] Saving user '{username}' in Sql database ✅");
        }
    }
}
