using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BudgetManagerAPI.Controllers
{
    [ApiController]
    public class CategoriesController : Controller
    {
        [Route("api/categories")]
        public async Task<IActionResult> GetCategories (string token)
        {
            return null;
        }
    }
}