using Business.Contracts.User;

namespace Business.Providers
{
    public interface IUserProvider
    {
        Task<List<User>> GetAllUsers();
    }
}
