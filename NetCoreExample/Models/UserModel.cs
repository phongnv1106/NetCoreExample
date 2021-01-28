using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreExample.Models
{
    public class UserModel
    {
        public UserModel(string userName, string password, string email)
        {
            UserName = userName;
            Password = password;
            Email = email;
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
