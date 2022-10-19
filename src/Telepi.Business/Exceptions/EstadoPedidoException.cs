using Telepi.Business.ValueObjects;
using Telepi.Business.Enums;
using Telepi.Business.Entities;

namespace Telepi.Business.Exceptions;

public class EstadoPedidoException : Exception
{
    Pedido Pedido;
    EstadoPedido Origen;
    EstadoPedido Destino;

    public EstadoPedidoException(Pedido pedido, EstadoPedido origen, EstadoPedido destino)
    {
        Pedido = pedido;
        Origen = origen;
        Destino = destino;
    }
}

