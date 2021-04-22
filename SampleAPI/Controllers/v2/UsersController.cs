using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SampleAPI.Models;

namespace SampleAPI.Controllers.v2
{
    [ApiController]
    //[Route("api/v{version:apiVersion}/users")]
    [Route("api/users")]
    [ApiVersion("2.0")]
    public class UsersController : ControllerBase
    {
        [HttpGet()]
        public IActionResult AllUsers()
        {
            // mimiking db operation
            List<UserV2> users = new List<UserV2>()
            {
                new UserV2
                {
                    Id = Guid.NewGuid(),
                    Name = "Mohamad"
                },
                new UserV2
                {
                    Id = Guid.NewGuid(),
                    Name = "Donald Duck"
                },
                new UserV2
                {
                    Id = Guid.NewGuid(),
                    Name = "Neil"
                }
            };

            return Ok(users);
        }
    }
}