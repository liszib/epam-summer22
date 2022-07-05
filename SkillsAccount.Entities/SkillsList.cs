using System;
using System.Collections.Generic;
using System.Text;

namespace SkillsAccount.Entities
{
    public class SkillsList
    {
        public SkillsList()
        {
            userID = Guid.NewGuid();
            skillID = Guid.NewGuid();
        }

        public Guid userID { get; }

        public Guid skillID { get; }

    }
}
