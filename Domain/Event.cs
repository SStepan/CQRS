using System;
using MediatR;

namespace CQRS.Domain
{
    public abstract class Event : INotification
    {
        protected Event(object entityId)
        {
            EntityId = Guid.NewGuid();
            EntityId = entityId;
            Timestamp = DateTime.UtcNow;;
        }

        public Guid EventId { get; set; }
        public object EntityId { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
