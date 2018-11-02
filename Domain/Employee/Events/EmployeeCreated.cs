using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace CQRS.Domain.Employee.Events
{
    public class EmployeeCreated : Event, INotification
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EmployeeCreated(object entityId, string firstName, string lastName) : base(entityId)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
