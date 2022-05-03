using MediatR;

namespace Sample.Domain.SeedWork;

public interface IDomainEvent : INotification
{
    DateTimeOffset OccurredOn { get; }
}
