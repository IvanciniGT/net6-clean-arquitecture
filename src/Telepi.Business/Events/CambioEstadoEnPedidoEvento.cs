using Telepi.Business.ValueObjects;
using Telepi.Business.Entities;
using Telepi.Business.Enums;

namespace Telepi.Business.Events;

public class CambioEstadoEnPedidoEvento 
{
    public Pedido Pedido { get; private set; }
    public EstadoPedido NuevoEstado { get; private set; }

    public CambioEstadoEnPedidoEvento(Pedido pedido, EstadoPedido nuevo) {
        Pedido = pedido;
        NuevoEstado = nuevo;
    }
}

