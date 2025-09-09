namespace DIP.Not_Use
{
    public class UserManager
    {
        private UserRepository _userRepo = new UserRepository();

        public void CreateUser(string username)
        {
            _userRepo.Save(username);
        }
    }
}
