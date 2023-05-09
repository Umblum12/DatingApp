using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")] // /api/users
    public class UsersController : ControllerBase
    {
        private readonly DataContext _Context;
        public UsersController(DataContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _Context.Users.ToListAsync();
            return users;
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<AppUser>> GetUser(int Id)
        {
            return await _Context.Users.FindAsync(Id);
        }
    }
}