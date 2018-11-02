using System;
using CQRS.Domain;
using System.Collections.Generic;
using System.Text;
using CQRS.Domain.Employee.Domain;
using CQRS.Domain.Employee.Events;

namespace CQRS.Employee.Domain
{
    class Employee : EventAggregate
    {
        private readonly Dictionary<string, Expertise> _skills = new Dictionary<string, Expertise>();
        private readonly List<ExperienceRecord> _experienceHistory = new List<ExperienceRecord>();

        public Employee(string firstName, string lastName)
        {
            RaiseEvent(new EmployeeCreated(EntityId, firstName, lastName));
        }

        public void SetExpertize(string skillName, int level)
        {
            RaiseEvent(new EmployeeExpertiseSet(EntityId, skillName, level));
        }

        internal void Apply(EmployeeCreated @event)
        {
            FirstName = @event.FirstName;
            LastName = @event.LastName;
        }

        internal void Apply(EmployeeExpertiseSet @event)
        {
            _skills[@event.SkillName] = new Expertise(@event.SkillName, @event.Level);
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
