using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServerSideValidation.Data;
using ServerSideValidation.Model;
using System.Collections.Generic;
using System.Net;

namespace ServerSideValidation.Controllers
{
    [ApiController]
    [Route("api/usersValidation")]
    public class UserController : Controller
    {
        private readonly ValidationApiDbContext _dbContext;

        public UserController(ValidationApiDbContext dbContext )
        {
            _dbContext = dbContext;
        }

        [HttpGet]   
        public async Task <ActionResult> Getuser()
        {
            return Ok(await _dbContext.Users.ToListAsync());
        }

        [HttpPost]

        public async Task<ActionResult>AddUser([FromBody] UsersDto adduser)
        {
            var user = new Users()
            {
                Id = new Guid(),
                UserName = adduser.UserName,
                Email = adduser.Email,
                Password = adduser.Password,
                ConfirmPassword = adduser.ConfirmPassword,
                Contact = adduser.Contact,
              Addresses = adduser.Addresses,
              AgreeToTermsWithValidation=adduser.AgreeToTermsWithValidation,
            
                
            };
            await _dbContext.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return Ok(user);
            
        }
        
    }
}
