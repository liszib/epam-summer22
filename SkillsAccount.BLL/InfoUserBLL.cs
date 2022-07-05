using System;
using System.Collections.Generic;
using System.Text;
using SkillsAccount.DAL;
using SkillsAccount.DAL.Interfaces;
using SkillsAccount.BLL.Interfaces;
using SkillsAccount.Entities;

namespace SkillsAccount.BLL
{
    public class InfoUserBLL : IInfoUserBLL
    {
        private IInfoUserDAL accountDAL;
        public InfoUserBLL()
        {
            infouserDAL = new infouserDAL();
        }
        public void AddInfoUser(InfoUser infouser)
        {
            infouserDAL.AddInfoUser(infouser);
        }
        public void ModifyInfoUser(InfoUser infouser)
        {
            infouserDAL.ModifyInfoUser(infouser);
        }
        public void RemoveInfoUser(int userID)
        {
            infouserDAL.RemoveInfoUser(userID);
        }

    }
}