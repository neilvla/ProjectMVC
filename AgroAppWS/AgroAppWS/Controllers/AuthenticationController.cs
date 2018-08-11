using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace AgroAppWS.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpGet("ValidateUser/{email}/{pass}")]
        public User Validate(string email, string pass)
        {
            return UserBL.Instance.validateUser(email, pass);
        }

        [HttpPost("MyValidate")]
        public string MyValidate(string email, string pass)
        {
            return "Hola";//UserBL.Instance.validateUser(email, pass);
        }
    }
}