using System;
using System.Collections.Generic;
using System.Text;

namespace SkillsAccount.Entities
{
    public class Users
    {
        public Users(string name, DateTime dateOfBirth)
        {
            ID = Guid.NewGuid();
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public Guid ID { get; }

        public string Name { get; set; }
        
        public DateTime DateOfBirth { get; set; }
    }
}
