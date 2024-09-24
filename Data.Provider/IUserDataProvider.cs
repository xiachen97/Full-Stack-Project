using Data.Contracts.User;
namespace Data.Providers
{
    public interface IUserDataProvider
    {
        Task<List<User>> GetAllUsers();
    }
}
