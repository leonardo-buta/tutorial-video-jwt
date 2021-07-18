using TutorialJwt.Models;

namespace TutorialJwt.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(User user);
    }
}
