using CoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi.Services
{
    public class UserService
    {
        /// <summary>
        /// Here I created Hardcoded users data, we also done it it with different data source
        /// </summary>
        /// Developed by : Rahul raval
        /// Date : 22/07/2019
        /// <returns>List of Users</returns>
        
        public List<UserModel> GetAllUsers()
        {
            List<UserModel> lstUsers = new List<UserModel>();

            lstUsers.Add(new UserModel() { FirstName = "Ashfaq", LastName = "Shaikh" });
            lstUsers.Add(new UserModel() { FirstName = "Priyesh", LastName = "Dixit" });
            lstUsers.Add(new UserModel() { FirstName = "Shahbaz", LastName = "Vohra" });
            lstUsers.Add(new UserModel() { FirstName = "Sanjay", LastName = "Chauhan" });
            lstUsers.Add(new UserModel() { FirstName = "Abbas", LastName = "Momin" });
            lstUsers.Add(new UserModel() { FirstName = "Shahrukh", LastName = "Makarani" });
            lstUsers.Add(new UserModel() { FirstName = "Kaushik", LastName = "Rathod" });

            return lstUsers;
        }
    }

    public interface IUserService
    {
        List<UserModel> GetAllUsers();
    }
}
