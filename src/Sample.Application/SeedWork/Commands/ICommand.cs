using MediatR;

namespace Sample.Application.SeedWork.Commands;

public interface ICommand : IRequest
{
    public Guid Id { get; }
}

public interface ICommand<out TResult> : IRequest<TResult>
{
    Guid Id { get; }
}
