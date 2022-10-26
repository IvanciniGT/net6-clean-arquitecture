using Telepi.Application.Dtos;

namespace Telepi.Application.Commons.Mediator;

public interface IMediadorComandos
{
    void subscribe<T>(ICommandHandler<T> handler);

    Respuesta<T> execute<T>(ICommand comando);

}

