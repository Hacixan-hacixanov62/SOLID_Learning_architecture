namespace DIP.Use
{
    public class UserManager
    {
        private readonly IUserRepository _userRepo;
        public UserManager(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }
        public void CreateUser(string username)
        {
            _userRepo.Save(username);
        }
    }
}
