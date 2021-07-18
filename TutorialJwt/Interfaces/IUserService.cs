using TutorialJwt.Models;

namespace TutorialJwt.Interfaces
{
    public interface IUserService
    {
        User GetUser(string email, string password);
    }
}
