using Sample.Domain.SeedWork;

namespace Sample.Domain.Orders.Events;

public class OrderCreatedEvent : DomainEventBase
{
    public string OrderId { get; }

    public string UserId { get; }

    public OrderCreatedEvent(
        string orderNo,
        string userId)
    {
        OrderId = orderNo;
        UserId = userId;
    }
}
