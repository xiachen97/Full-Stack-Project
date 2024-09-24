using Api.Contracts.User;
using Microsoft.AspNetCore.Mvc;
using Business.Providers;
using Api.Translators.User;

namespace API.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController: ControllerBase
    {
        private readonly IUserProvider _userProvider;
        private readonly IUserTranslator _userTranslator;
        public UsersController(IUserProvider userProvider, IUserTranslator userTranslator)
        {
            _userProvider = userProvider;
            _userTranslator = userTranslator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users =  await _userProvider.GetAllUsers();
            return Ok(_userTranslator.ToApi(users));
        }

        //api/users/3
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            return null;
        }
    }
}