using AutoMapper;

namespace Business.Translators.User
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<Data.Contracts.User.User, Contracts.User.User>();
        }
    }
}
