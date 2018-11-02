using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using CQRS.Domain.Core;
using MediatR;

namespace CQRS.Domain.Employee.Commands
{
    public class SetEmployeeExpertiseCommand : Core.ICommand
    {
        public Guid EmployeeId { get; set; }

        public string SkillName { get; set; }

        public int ExpertiseLevel { get; set; }

        public TimeSpan ExpirePeriod { get; set; }
    }
}
