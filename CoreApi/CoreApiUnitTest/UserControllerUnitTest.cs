using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreApi.Controllers;
using CoreApi.Models;
using Xunit;
using CoreApi.Services;

namespace CoreApiUnitTest
{
    public class UserControllerUnitTest
    {
        /// <summary>
        /// It is Unit Test it will test actions from UserControlller and give a Success or Failed state
        /// </summary>
        /// Developed by : Rahul raval
        /// Date : 22/07/2019
        /// <returns>List of Users</returns>
        
        [Fact]
        public void TestGetAllUsers()
        {
            var controller = new UserController();

            // Act
            var response = controller.GetAllUsers() as ObjectResult;
            var result = response != null ? false : true;

            // Assert
            Assert.False(result);
        }
    }
}
