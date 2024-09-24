using AutoMapper;

namespace Api.Translators.User;

public class UserProfile: Profile
{
    public UserProfile()
    {
        CreateMap<Business.Contracts.User.User, Contracts.User.User>();
    }
}