using Telepi.Business.ValueObjects;
using Telepi.Business.Entities;
using Telepi.Business.Enums;

namespace Telepi.Business.Events;

public class PedidoEntregadoEvento : CambioEstadoEnPedidoEvento
{
    public PedidoEntregadoEvento(Pedido pedido) : base(pedido, EstadoPedido.ENTREGADO)
    {
    }
}

