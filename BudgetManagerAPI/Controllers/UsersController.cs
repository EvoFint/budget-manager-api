using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BudgetManagerAPI.Controllers
{
    [ApiController]
    public class UsersController : Controller
    {
        [Route("api/users")] 
        public async Task<IActionResult> GetUsers (string token)
        {
            using (AppContext db = new AppContext())
            {
                var users = await db.Users
                    .ToListAsync();
                return Json(users
                    .Select(u => new {name = u.UserName, email = u.Email}));
            }
        }
    }
}