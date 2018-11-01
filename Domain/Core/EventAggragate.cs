using System;
using System.Collections.Generic;
using System.Linq;

namespace CQRS.Domain
{
    public class EventAggregate : Entity
    {
        private readonly List<Event> _uncommittedChanges = new List<Event>();
        private readonly Dictionary<Type, Action<Event>> _eventHandlers = new Dictionary<Type, Action<Event>>();

        public IReadOnlyCollection<Event> GetUncommitted()
        {
            return _uncommittedChanges;
        }

        public void MarkAsCommitted()
        {
            _uncommittedChanges.Clear();
        }

        public void ApplyHistory(IEnumerable<Event> historicalEvents)
        {
            foreach (var historicalEvent in historicalEvents)
            {
                ApplyEvent(historicalEvent, false);
            }
        }

        protected void RegisterEventHandler<TEvent>(Action<TEvent> handler) where TEvent : Event
        {
            Action<Event> genericHandler = eventInstance => handler.Invoke((TEvent)eventInstance);
            _eventHandlers[typeof(TEvent)] = genericHandler;
        }

        public void ApplyEvent(Event @event)
        {
            if (!_uncommittedChanges.Any(t => t.EventId == @event.EventId))
            {
                ((dynamic) this).Apply((dynamic) @event);
            }
        }

        private void ApplyEvent<TEvent>(TEvent instance, bool isNew) where  TEvent : Event
        {
            if (instance == null)
            {
                throw new ArgumentNullException(nameof(instance), "Event instance cannot be null.");
            }

            if (isNew)
            {
                _uncommittedChanges.Add(instance);
            }

            if (!_eventHandlers.ContainsKey(instance.GetType()))
            {
                throw new NotSupportedException($"Event of type '{typeof(TEvent)}' cannot be handled because no handler was registered.");
            }

            _eventHandlers[instance.GetType()].Invoke(instance);
        }
    }
}
