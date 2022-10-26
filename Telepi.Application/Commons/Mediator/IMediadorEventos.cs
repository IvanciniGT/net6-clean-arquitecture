using Telepi.Business.Commons;
using Telepi.Business.Events;

namespace Telepi.Application.Commons.Mediator;

public abstract class IMediadorEventos : IMediador
{
    // Oculta el metodo hacia arriba.
    void IMediador.publish(CambioEstadoEnPedidoEvento cambioDeEstadoEnPedidoEvento)
    {
        publish(MapEvent(cambioDeEstadoEnPedidoEvento));
    }


    public abstract void publish(Evento evento);

    public abstract void subscribe(IEventHandler handlerEventos);

    // Helpers
    private static Evento MapEvent(CambioEstadoEnPedidoEvento cambioDeEstadoEnPedidoEvento) {
        Evento evento = new Evento(); // Mapeo entre cambioDeEstadoEnPedidoEvento ->evento
        evento.NuevoEstado = (int)cambioDeEstadoEnPedidoEvento.NuevoEstado;
        evento.PedidoId = cambioDeEstadoEnPedidoEvento.Pedido.Id;
        return evento;
    }
}

