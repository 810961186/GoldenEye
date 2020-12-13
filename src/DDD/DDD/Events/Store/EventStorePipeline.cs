using System;
using System.Threading;
using System.Threading.Tasks;
using GoldenEye.Backend.Core.DDD.Events.Store;

namespace GoldenEye.Backend.Core.DDD.Events.Logging
{
    public class EventStorePipeline<TEvent>: IEventHandler<TEvent>
        where TEvent : IEvent
    {
        private readonly IEventStore eventStore;

        public EventStorePipeline(IEventStore eventStore)
        {
            this.eventStore = eventStore ?? throw new ArgumentException(nameof(eventStore));
        }

        public async Task Handle(TEvent @event, CancellationToken cancellationToken)
        {
            await eventStore.StoreAsync(@event.StreamId, cancellationToken, @event);
            await eventStore.SaveChangesAsync(cancellationToken);
        }
    }
}
