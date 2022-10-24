using Telepi.Business.Commons;
using Telepi.Business.Enums;
using Telepi.Business.Events;
using Telepi.Business.Exceptions;
using Telepi.Business.ValueObjects;

namespace Telepi.Business.Entities  // POCO 
{
    public class Pedido 
    {

        public int Id { get;  internal set; }
        public string Cliente { get; private set; }
        public EstadoPedido Estado { get; private set; }
        public IReadOnlyCollection<PizzaPersonalizada> PizzasPersonalizadas { get; private set; }
        public IReadOnlyCollection<Pizza> Pizzas { get; private set; } // No persistirlo
        private IMediador mediador;

        public Pedido(IMediador mediador,  string cliente, IReadOnlyCollection<PizzaPersonalizada> pizzasPersonalizadas)
        {
            Cliente = cliente;
            PizzasPersonalizadas = pizzasPersonalizadas;
            Estado = EstadoPedido.RECIBIDO;
        }

        public void entregado()
        {
            if (this.Estado != EstadoPedido.EN_REPARTO)
                throw new EstadoPedidoException(this, this.Estado, EstadoPedido.EN_REPARTO);
            this.Estado = EstadoPedido.ENTREGADO;
            mediador.publish(new PedidoEntregadoEvento(this));
        }

        public void enReparto()
        {
            if (this.Estado != EstadoPedido.LISTO)
                throw new EstadoPedidoException(this, this.Estado, EstadoPedido.LISTO);
            this.Estado = EstadoPedido.EN_REPARTO;
            mediador.publish(new PedidoEnRepartoEvento(this));
        }


        public void comenzarPedido()
        {
            if (this.Estado != EstadoPedido.RECIBIDO)
                throw new EstadoPedidoException(this, this.Estado, EstadoPedido.RECIBIDO);
            this.Estado = EstadoPedido.EN_PROCESO;
            mediador.publish(new PedidoEnPreparacionEvento(this));
        }

        internal void notificarQueLaPizzaEstaLista() {
            if (this.Estado != EstadoPedido.EN_PROCESO)
                throw new EstadoPedidoException(this, this.Estado, EstadoPedido.EN_PROCESO);
            if (Pizzas.All(pizza => pizza.Lista))
            {
                Estado = EstadoPedido.LISTO;
                mediador.publish(new PedidoListoEvento(this));
            }
        }
    }
}

