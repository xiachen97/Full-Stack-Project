
using AutoMapper;

namespace Business.Translators.User;

public class UserTranslator : IUserTranslator
{
    private readonly IMapper _mapper;
    public UserTranslator(IMapper mapper)
    {
        _mapper = mapper;
    }
    public List<Contracts.User.User> ToBusiness(List<Data.Contracts.User.User> users)
    {
        return users.Select(x => _mapper.Map<Business.Contracts.User.User>(x)).ToList();
    }
}