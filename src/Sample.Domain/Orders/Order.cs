using Sample.Domain.Orders.Events;
using Sample.Domain.SeedWork;

namespace Sample.Domain.Orders;

public class Order : Entity, IAggregateRoot
{
    public string UserId { get; set; }

    public DateTimeOffset CreationTime { get; set; }

    private Order(string userId)
    {
        Id = Guid.NewGuid().ToString();
        CreationTime = DateTimeOffset.Now;
        UserId = userId;
        AddDomainEvent(new OrderCreatedEvent(Id, UserId));
    }

    public static Order CreateNew(string userId) => new Order(userId);
}
