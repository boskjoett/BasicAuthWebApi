using System.Linq;
using System.Collections.Generic;

namespace BasicAuthWebApi.Authentication
{
    public class UserService : IUserService
    {
        private List<User> _users = new List<User>
        {
            new User { Id = 1, Username = "zyadmin", Password = "zysecret" }
        };

        public User Authenticate(string username, string password)
        {
            return _users.SingleOrDefault(x => x.Username == username && x.Password == password);
        }
    }
}
