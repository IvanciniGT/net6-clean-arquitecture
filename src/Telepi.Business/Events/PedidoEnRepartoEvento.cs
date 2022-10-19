using Telepi.Business.ValueObjects;
using Telepi.Business.Entities;
using Telepi.Business.Enums;

namespace Telepi.Business.Events;

public class PedidoEnRepartoEvento : CambioEstadoEnPedidoEvento
{
    public PedidoEnRepartoEvento(Pedido pedido) : base(pedido, EstadoPedido.EN_REPARTO)
    {
    }
}

