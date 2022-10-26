using Telepi.Application.Dtos;

namespace Telepi.Application.Commons.Mediator;

public interface IMediadorComandos
{
    //void subscribe(ICommandHandler handler);
    void subscribeToComand<H, C>() where H : ICommandHandler where C : ICommand;


    Respuesta execute(ICommand comando);

}

