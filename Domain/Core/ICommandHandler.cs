using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace CQRS.Domain.Core
{
    public interface ICommandHandler <in T> : IRequestHandler<T>
        where T : ICommand
    {
    }
}
