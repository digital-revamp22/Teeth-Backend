namespace Teeth.Application.Interfaces;

public interface IRequest<TResponse>
{
}

public interface IRequestHandler<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    Task<TResponse> Handle(TRequest request);
}