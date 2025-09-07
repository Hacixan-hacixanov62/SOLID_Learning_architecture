using Comman.Models;

namespace SRP.Use
{
    public class UserManager
    {
        private readonly UserValidation _validation = new UserValidation();
        private readonly UserRepository _repository = new UserRepository();

        public void AddUser(User user)
        {
            if(_validation.Validate(user))
            {
                _repository.Save(user);
            }
            else
            {
                throw new Exception("User is not valid");
            }
        }
    }
}
