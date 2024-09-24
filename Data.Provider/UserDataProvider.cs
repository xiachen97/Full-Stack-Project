using Data.Contracts.User;
using Data.Provider.Data;
using Data.Providers;

namespace Data.Provider
{
    public class UserDataProvider : IUserDataProvider
    {
        private readonly DataContext _context;
        public UserDataProvider(DataContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return _context.Users.ToList();
        }
    }
}
