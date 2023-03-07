using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users.Users
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }
        public string role { get; set; }
        public string email { get; set; }

        public User(int id, string username, string firstname, string lastname, string password, string role, string email)
        {
            Id = id;
            Username = username;
            FirstName = firstname;
            Lastname = lastname;
            Password = password;
            role = role;
            email = email;
        }


    }
}
