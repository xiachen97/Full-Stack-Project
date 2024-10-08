using Microsoft.AspNetCore.Mvc;
using API.Data; 
using API.Entities; 
using System.Collections.Generic; 
using Microsoft.EntityFrameworkCore;//async

namespace API.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController: ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context){
            _context=context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){
            return await _context.Users.ToListAsync();
        }

        //api/users/3
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id){
            return await _context.Users.FindAsync(id); 
        }
    }
}