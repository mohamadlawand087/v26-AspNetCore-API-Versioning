using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SampleAPI.Models;

namespace SampleAPI.Controllers.v1
{
    [ApiController]
    [Route("api/users")]
    [ApiVersion("1.0", Deprecated = true)]
    public class UsersController : ControllerBase
    {
        [HttpGet()]
        public IActionResult AllUsers()
        {
            // mimiking db operation
            List<UserV1> users = new List<UserV1>()
            {
                new UserV1
                {
                    Id = 1,
                    Name = "Mohamad"
                },
                new UserV1
                {
                    Id = 2,
                    Name = "Donald Duck"
                },
                new UserV1
                {
                    Id = 3,
                    Name = "Neil"
                }
            };

            return Ok(users);
        }
    }
}