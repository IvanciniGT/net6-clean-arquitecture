using Telepi.Application.Entities.Pedidos.Commands;

namespace Telepi.Application.Commons.Mediator;

public interface ICommandHandler
{
    Respuesta handle(ICommand comando);
}
