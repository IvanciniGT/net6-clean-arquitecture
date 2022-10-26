using Telepi.Application.Commons.Mediator;

namespace Telepi.Infrastructure.Mediator.Command;

public class MediadorComandos: IMediadorComandos
{
    public MediadorComandos()
    {
    }

    Respuesta<T> IMediadorComandos.execute<T>(ICommand comando)
    {
        throw new NotImplementedException();
    }

    void IMediadorComandos.subscribe<T>(ICommandHandler<T> handler)
    {
        throw new NotImplementedException();
    }
}

