
using AutoMapper;

namespace Api.Translators.User
{
    public class UserTranslator : IUserTranslator
    {
        private readonly IMapper _mapper;
        public UserTranslator(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List <Contracts.User.User> ToApi(List <Business.Contracts.User.User> users)
        {
            return users.Select(x => _mapper.Map<Contracts.User.User>(x)).ToList();
        }
    }
}
