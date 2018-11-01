using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Domain.Core
{
    public  interface IAggregate<TId>
    {
        TId Id { get; }
    }
}
