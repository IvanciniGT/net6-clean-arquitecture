using Telepi.Business.Commons;
using Telepi.Business.Events;

namespace Telepi.Application.Commons.Mediator;

public abstract class IMediadorEventos : IMediador
{

    public void publish(CambioEstadoEnPedidoEvento cambioDeEstadoEnPedidoEvento)
    {
        Evento evento; // Mapeo entre cambioDeEstadoEnPedidoEvento ->evento
        publish(evento);
    }


    public abstract void publish(Evento evento);

    public abstract void subscribe(IEventHandler handlerEventos);
}

