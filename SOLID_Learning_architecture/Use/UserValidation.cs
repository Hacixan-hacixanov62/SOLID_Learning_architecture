using Comman.Models;

namespace SRP.Use
{
    public class UserValidation
    {
        public bool Validate(User user)
        {
            return !string.IsNullOrEmpty(user.Name);
        }
    }
}
