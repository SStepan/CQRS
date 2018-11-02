using System.Collections.Generic;
using CQRS.Domain.Employee.Events;

namespace CQRS.Domain.Employee.Domain
{
    class Employee : EventAggregate
    {
        private readonly List<ExperienceRecord> _experienceHistory = new List<ExperienceRecord>();

        public Employee(string firstName, string lastName)
        {
            RaiseEvent(new EmployeeCreated(EntityId, firstName, lastName));
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
