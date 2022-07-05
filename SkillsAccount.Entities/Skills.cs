using System;
using System.Collections.Generic;
using System.Text;

namespace SkillsAccount.Entities
{
    public class Skills
    {
        public Skills(string name)
        {
            ID = Guid.NewGuid();
            Name = name;
        }

        public Guid ID { get; }

        public string Name { get; set; }

    }
}
