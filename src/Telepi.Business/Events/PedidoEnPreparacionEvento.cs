using Telepi.Business.ValueObjects;
using Telepi.Business.Entities;
using Telepi.Business.Enums;

namespace Telepi.Business.Events;

public class PedidoEnPreparacionEvento : CambioEstadoEnPedidoEvento
{
    public PedidoEnPreparacionEvento(Pedido pedido) : base(pedido, EstadoPedido.EN_PROCESO)
    {
    }
}

