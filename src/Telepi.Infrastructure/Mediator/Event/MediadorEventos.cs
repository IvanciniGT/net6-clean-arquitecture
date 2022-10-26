using Telepi.Application.Commons.Mediator;

namespace Telepi.Infrastructure.Mediator.Event;

public class MediadorEventos: IMediadorEventos
{

    private IList<IEventHandler> handlers;

    public MediadorEventos()
    {
        handlers = new List<IEventHandler>();
    }

    public override void publish(Evento evento)
    {
        foreach (IEventHandler handler in handlers)
            handler.notify(evento);
    }

    public override void subscribe(IEventHandler handlerEventos)
    { // Puedo tener muchos subscriptores
        handlers.Append(handlerEventos);

    }
}

