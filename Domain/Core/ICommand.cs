using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace CQRS.Domain.Core
{
    public interface ICommand : IRequest
    {
    }
}
