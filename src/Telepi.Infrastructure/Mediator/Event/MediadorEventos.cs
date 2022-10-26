using Telepi.Application.Commons.Mediator;

namespace Telepi.Infrastructure.Mediator.Event;

public class MediadorEventos: IMediadorEventos
{
    public MediadorEventos()
    {

    }

    public override void publish(Evento evento)
    {
        throw new NotImplementedException();
    }

    public override void subscribe(IEventHandler handlerEventos)
    {
        throw new NotImplementedException();
    }
}

