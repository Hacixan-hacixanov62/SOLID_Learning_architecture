using Comman.Models;

namespace SRP.NotUse
{
    public class UserManager
    {
        public void AddUser(User user)
        {
            if(string.IsNullOrEmpty(user.Name))
            {
                Console.WriteLine("User validation failed");
                return;
            }

           
            Console.WriteLine($"User '{user.Name}' saved to database.");
        }
    }
}
