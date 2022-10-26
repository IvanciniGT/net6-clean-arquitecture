using Telepi.Business.Commons;
using Telepi.Business.Enums;
using Telepi.Business.Events;
using Telepi.Business.Exceptions;
using Telepi.Business.ValueObjects;

namespace Telepi.Business.Entities  // POCO 
{
    public class Pedido 
    {

        public Guid Id { get;  set; }
        public string Cliente { get; set; }
        private EstadoPedido _Estado = EstadoPedido.NONE;
        
        public EstadoPedido Estado
        {
            get => _Estado;
            private set
            {
                if (value == EstadoPedido.EN_REPARTO && this._Estado != EstadoPedido.LISTO)
                    throw new EstadoPedidoException(this, this._Estado, EstadoPedido.EN_REPARTO);
                else if (value == EstadoPedido.LISTO && this._Estado != EstadoPedido.EN_PROCESO)
                    throw new EstadoPedidoException(this, this._Estado, EstadoPedido.LISTO);
                else if (value == EstadoPedido.RECIBIDO && this._Estado! != EstadoPedido.EN_REPARTO)
                    throw new EstadoPedidoException(this, this._Estado, EstadoPedido.RECIBIDO);
                else if (value == EstadoPedido.EN_PROCESO && this._Estado != EstadoPedido.RECIBIDO)
                    throw new EstadoPedidoException(this, this._Estado, EstadoPedido.EN_PROCESO);
                else if (value == EstadoPedido.RECIBIDO && this._Estado! != EstadoPedido.NONE)
                    throw new EstadoPedidoException(this, this._Estado, EstadoPedido.RECIBIDO);
                // Traer aquí la notificación ! El evento
                this._Estado = value;
            }
        }
        public IReadOnlyCollection<PizzaPersonalizada> PizzasPersonalizadas { get; set; }
        public IReadOnlyCollection<Pizza> Pizzas { get; set; } // No persistirlo
        private IMediador mediador;

        public Pedido(IMediador mediador,  string cliente, IReadOnlyCollection<PizzaPersonalizada> pizzasPersonalizadas)
        {
            this.Id=Guid.NewGuid(); // TODO, generar id numérico
            Cliente = cliente;
            PizzasPersonalizadas = pizzasPersonalizadas;
            Estado = EstadoPedido.RECIBIDO;
            // Evento
        }

        public void entregado()
        {
            this.Estado = EstadoPedido.ENTREGADO;
            mediador.publish(new PedidoEntregadoEvento(this));
        }

        public void enReparto()
        {
            this.Estado = EstadoPedido.EN_REPARTO;
            mediador.publish(new PedidoEnRepartoEvento(this));
        }


        public void comenzarPedido()
        {
            this.Estado = EstadoPedido.EN_PROCESO;
            mediador.publish(new PedidoEnPreparacionEvento(this));
        }

        internal void notificarQueLaPizzaEstaLista() {
            if (Pizzas.All(pizza => pizza.Lista))
            {
                Estado = EstadoPedido.LISTO;
                mediador.publish(new PedidoListoEvento(this));
            }
        }
    }
}

