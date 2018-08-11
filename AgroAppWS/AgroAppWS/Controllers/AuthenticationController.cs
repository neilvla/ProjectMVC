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
        //[HttpPost]
        //[ActionName("Post")]
        //public ActionResult<User> validateUser([FromBody]User u)
        //{
        //    return UserBL.Instance.validateUser(u.Email, u.Password);
        //}
        [HttpPost("validateUser")]
        public ActionResult<User> validateUser(User u)
        {
            return UserBL.Instance.validateUser(u.Email, u.Password);
        }
    }
}