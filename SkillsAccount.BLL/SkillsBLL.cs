using System;
using System.Collections.Generic;
using System.Text;
using SkillsAccount.DAL;
using SkillsAccount.DAL.Interfaces;
using SkillsAccount.BLL.Interfaces;
using SkillsAccount.Entities;

namespace SkillsAccount.BLL
{
    public class SkillsBLL : ISkillsBLL
    {
        private ISkillsDAL skillDAL;
        public SkillsBLL()
        {
            skillDAL = new SkillDAL();
        }
        public void AddSkill(Skills skill)
        {
            skillDAL.AddSkill(skill);
        }
        public void ModifySkill(Skills skill)
        {
            skillDAL.ModifySkill(skill);
        }
        public void RemoveSkill(int id)
        {
            skillDAL.RemoveSkill(id);
        }
    }
}