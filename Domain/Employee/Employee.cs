using System.Collections.Generic;

namespace CQRS.Domain.Employee
{
    class Employee : EventAggregate
    {
        private readonly List<ExperienceRecord> _experienceHistory = new List<ExperienceRecord>();

        public Employee()
        {
            RegisterEventHandler();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
