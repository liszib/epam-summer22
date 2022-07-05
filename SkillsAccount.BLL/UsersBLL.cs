using System;
using System.Collections.Generic;
using System.Text;
using SkillsAccount.DAL;
using SkillsAccount.DAL.Interfaces;
using SkillsAccount.BLL.Interfaces;
using SkillsAccount.Entities;

namespace SkillsAccount.BLL
{
    public class UsersBLL : IUsersBLL
    {
        private IUsersDAL userDAL;
        public UsersBLL()
        {
            userDAL = new UserDAL();
        }
        public Users AddUser(Users users)
        {
            return userDAL.AddUser(users);
        }
        public void ModifyUser(Users user)
        {
            userDAL.ModifyUser(user);
        }
        public void RemoveUser(int id)
        {
            userDAL.RemoveUser(id);
        }

    }
}
