using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using MediatR;

namespace CQRS.Domain.Employee.Commands
{
    public class CreateEmployeeCommand : Core.ICommand
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
