using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace CQRS.Domain.Employee.Events
{
    public class EmployeeExpertiseSet : Event, INotification
    {
        public string SkillName { get; set; }

        public int Level { get; set; }

        public EmployeeExpertiseSet(object entityId, string skillName, int level) : base(entityId)
        {
            SkillName = skillName;
            Level = level;
        }
    }
}
