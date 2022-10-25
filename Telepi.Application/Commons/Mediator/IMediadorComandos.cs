namespace Telepi.Application.Commons.Mediator;

public interface IMediadorComandos
{
    void subscribe<T>(ICommandHandler<T> handler);
}

