using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi.Models;
using CoreApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// It returns list of users
        /// </summary>
        /// Developed by : Rahul raval
        /// Date : 22/07/2019
        /// <returns>List of Users</returns>
        
        [Route("api/users")]
        [HttpGet]
        public ActionResult GetAllUsers()
        {
            UserService userService = new UserService();
            var lstUser = userService.GetAllUsers();

            var result = new
            {
                users = lstUser
            };

            return Ok(result);
        }
    }
}