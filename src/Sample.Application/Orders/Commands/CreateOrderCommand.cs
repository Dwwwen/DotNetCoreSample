namespace Sample.Application.Orders.Commands;

public class CreateOrderCommand
{
    public string UserId { get; set; }

    public CreateOrderCommand(string userId)
    {
        UserId = userId;
    }
}
