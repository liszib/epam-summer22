using System;
using System.Collections.Generic;
using System.Text;

namespace SkillsAccount.Entities
{
    public class InfoUser
    {
        public InfoUser(string login, string password, string role)
        {
            userID = Guid.NewGuid();
            Login = login;
            Password = password;
            Role = role;
        }

        public Guid userID { get; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Role { get; set; } //admin or user
    }
}
