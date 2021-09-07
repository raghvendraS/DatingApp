using datingApp.Data;
using datingApp.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace datingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly DataContext _conxt;
        public UsersController(DataContext context  )
        {
            this._conxt = context;
        }

        [HttpGet]
        public async Task<ActionResult <IEnumerable<AppUser>>> GetUsers()
        {
            return await _conxt.Users.ToListAsync();
            
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUsers(int id)
        {
           return await _conxt.Users.FindAsync(id);
            
        }
    }
}
