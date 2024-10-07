using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace back_forms.src.Controllers
{
    [ApiController]
    [Route("epm/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(){
            return Ok();
        }

    }
}