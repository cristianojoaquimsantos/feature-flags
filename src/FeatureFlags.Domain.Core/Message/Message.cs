namespace FeatureFlags.Domain.Core.Message;

public abstract class Message
{
    public string MessageType { get; protected set; }
    public Guid AggregateId { get; protected set; } = Guid.NewGuid();

    public Message()
    {
        MessageType = GetType().Name;
    }
}