using Business.Contracts.User;
using Business.Translators.User;
using Data.Providers;

namespace Business.Providers
{
    public class UserProvider : IUserProvider
    {
        private readonly IUserDataProvider _userDataProvider;
        private readonly IUserTranslator _userTranslator;

        public UserProvider(IUserDataProvider userDataProvider, IUserTranslator userTranslator) {
            _userDataProvider = userDataProvider;
            _userTranslator = userTranslator;
        }

        public async Task<List<User>> GetAllUsers()
        {
            var users = await _userDataProvider.GetAllUsers();
            return _userTranslator.ToBusiness(users);
        }
    }
}
