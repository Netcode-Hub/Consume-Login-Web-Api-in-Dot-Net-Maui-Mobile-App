using LoginApp.Model;

namespace LoginApp.Repository;

public interface IUserRepository
{
    Task<User> Login(string email, string password);
}
