using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Domain.Employee.Domain
{
    public class Expertise
    {
        public string Skill { get; }

        public int Level { get; }
        public Expertise(string skillName, int level)
        {
            Skill = skillName;
            Level = level;
        }
    }
}
