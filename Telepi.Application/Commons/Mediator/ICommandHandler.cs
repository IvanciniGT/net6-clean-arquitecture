using Telepi.Application.Entities.Pedidos.Commands;

namespace Telepi.Application.Commons.Mediator;

public interface ICommandHandler<T>
{
    Respuesta<T> handle(ICommand comando);
}
