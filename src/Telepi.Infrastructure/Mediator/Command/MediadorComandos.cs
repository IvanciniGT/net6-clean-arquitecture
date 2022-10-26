using Telepi.Application.Commons.Mediator;

namespace Telepi.Infrastructure.Mediator.Command;

public class MediadorComandos: IMediadorComandos
{
    private ICommandHandler? handler;

    public MediadorComandos()
    {
    }

    Respuesta IMediadorComandos.execute(ICommand comando)
    {
        //if (this.handler is null)
        //    throw new Exception("Handler Not Assigned");
        // Buscar en el mapa el handler correspondiente:
        // Instanciar el Handler

        return handler.handle(comando);
    }
    /*
    void IMediadorComandos.subscribe(ICommandHandler handler) // Solo puede haber 1 único subscriptor
    {
        if(this.handler is not null)
            throw new Exception("Handler Already Assigned");
        this.handler=handler;
    }*/
    
    public void subscribeToComand<H, C>() where H : ICommandHandler where C : ICommand
    {
        //Guardar en un Map los tipos
    }

}

