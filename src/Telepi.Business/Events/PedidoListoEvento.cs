using Telepi.Business.ValueObjects;
using Telepi.Business.Entities;
using Telepi.Business.Enums;

namespace Telepi.Business.Events;

public class PedidoListoEvento : CambioEstadoEnPedidoEvento
{
    public PedidoListoEvento(Pedido pedido) : base(pedido, EstadoPedido.LISTO)
    {
    }
}

