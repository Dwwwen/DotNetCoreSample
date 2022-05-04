namespace Sample.Domain.SeedWork;

public class DomainEventBase : IDomainEvent
{
    public DateTimeOffset OccurredOn { get; }

    public DomainEventBase()
    {
        OccurredOn = DateTimeOffset.Now;
    }
}