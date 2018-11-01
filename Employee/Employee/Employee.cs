using CQRS.Domain;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Employee.Domain
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

        public Employee(string firstName, string lastName)
        {
            
        }
    }
}
