using System;
using Telepi.Business.Enums;
using Telepi.Business.Entities;
using Telepi.Business.Exceptions;

namespace Telepi.Business.Aggregates
{
    public static class PedidoAggregate
    {

        public static void entregado(this Pedido pedido)
        {
            if (pedido.Estado != EstadoPedido.EN_REPARTO)
                throw new EstadoPedidoException(pedido, pedido.Estado, EstadoPedido.EN_REPARTO);
            pedido.Estado = EstadoPedido.ENTREGADO;
        }

        public static void enReparto(this Pedido pedido)
        {
            if (pedido.Estado != EstadoPedido.LISTO)
                throw new EstadoPedidoException(pedido, pedido.Estado, EstadoPedido.LISTO);
            pedido.Estado = EstadoPedido.EN_REPARTO;
        }

        // Estado = EstadoPedido.LISTO;

        public static void comenzarPedido(this Pedido pedido)
        {
            if (pedido.Estado != EstadoPedido.RECIBIDO)
                throw new EstadoPedidoException(pedido, pedido.Estado, EstadoPedido.RECIBIDO);
            pedido.Estado = EstadoPedido.EN_PROCESO;
        }

    }
}

