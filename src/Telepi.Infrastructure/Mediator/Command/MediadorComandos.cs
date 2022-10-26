using Telepi.Application.Commons.Mediator;

namespace Telepi.Infrastructure.Mediator.Command;

public class MediadorComandos: IMediadorComandos
{
    private ICommandHandler? handler;
    private Dictionary<Type,Type> handlers;

    public MediadorComandos(  )
    {
        this.handlers=new Dictionary<Type, Type>();
    }

    Respuesta IMediadorComandos.execute(ICommand comando)
    {
        //if (this.handler is null)
        //    throw new Exception("Handler Not Assigned");
        // Buscar en el mapa el handler correspondiente:
        Type handlerType = handlers[comando.GetType()];
        // Correspondientes compraciones
        // Instanciar el Handler
        ICommandHandler handler;
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
        // Comprobación. Si ya existe error o que se machaque
        this.handlers.Add(typeof(C), typeof(H));
    }

}

