using MediatR;

namespace FeatureFlags.Domain.Core.Message;

public abstract class Event : Message, INotification
{
    public DateTime Timestamp { get; set; }

    protected Event()
    {
        Timestamp = DateTime.Now;
    }
}