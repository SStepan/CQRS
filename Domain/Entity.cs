using System;

namespace CQRS.Domain
{
    public abstract class Entity
    {
        protected Entity()
        {
            EntityId = Guid.NewGuid();
        }

        public object EntityId { get; set; }
    }
}