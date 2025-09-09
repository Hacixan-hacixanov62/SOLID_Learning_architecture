using Comman.Models;

namespace DIP.Use
{
    public class MongoUserRepository : IUserRepository
    {
        public void Save(string username)
        {
            Console.WriteLine($"[Use] Saving user '{username}' in MongoDB ✅");
        }
    }
}
