using Telepi.Application.Dtos;

namespace Telepi.Application.Commons.Mediator;

public interface IMediadorComandos
{
    void subscribe(ICommandHandler handler);

    Respuesta execute(ICommand comando);

}

