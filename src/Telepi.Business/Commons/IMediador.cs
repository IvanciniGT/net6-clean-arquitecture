using Telepi.Business.Events;

namespace Telepi.Business.Commons;

public interface IMediador
{

    public void publish(CambioEstadoEnPedidoEvento cambioDeEstadoEnPedidoEvento);

}

