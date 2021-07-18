using System.Collections.Generic;
using System.Linq;
using TutorialJwt.Interfaces;
using TutorialJwt.Models;

namespace TutorialJwt.Services
{
    public class UserService : IUserService
    {
        private List<User> GetUserList()
        {
            return new List<User>
            {
                new User { Id = 1, Name = "User TI", Email = "test@test.com", Password = "123", Roles = new List<string>  { "TI" } },
                new User { Id = 2, Name = "User Admin", Email = "test2@test.com", Password = "123", Roles = new List<string> { "Admin", "TI" } },
                new User { Id = 3, Name = "User Marketing", Email = "test3@test.com", Password = "123", Roles = new List<string> { "Marketing" } },
            };
        }

        public User GetUser(string email, string password)
        {
            return GetUserList().Where(x => x.Email == email && x.Password == password).FirstOrDefault();
        }
    }
}
