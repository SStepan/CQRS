using System;
using System.Threading;
using System.Threading.Tasks;
using CQRS.Domain.Core;
using MediatR;

namespace CQRS.Domain.Employee.Commands
{
    class EmployeeCommandHandler : 
        ICommandHandler<CreateEmployeeCommand>,
        ICommandHandler<SetEmployeeExpertiseCommand>
    {
        public Task<Unit> Handle(CreateEmployeeCommand command, CancellationToken cancellationToken)
        {
            var employee = new Domain.Employee(command.FirstName, command.LastName);
        }

        public Task<Unit> Handle(SetEmployeeExpertiseCommand command, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
