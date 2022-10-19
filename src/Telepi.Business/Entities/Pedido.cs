using Telepi.Business.Commons;
using Telepi.Business.Enums;
using Telepi.Business.ValueObjects;

namespace Telepi.Business.Entities  // POCO 
{
    public class Pedido 
    {

        public int Id { get;  set; }
        public string Cliente { get; set; }
        public EstadoPedido Estado { get; set; }
        public IReadOnlyCollection<PizzaPersonalizada> PizzasPersonalizadas { get; private set; }
        public IReadOnlyCollection<Pizza> Pizzas { get; private set; } // No persistirlo

        public Pedido(int id, string cliente, IReadOnlyCollection<PizzaPersonalizada> pizzasPersonalizadas)
        {
            Id = id;
            Cliente = cliente;
            PizzasPersonalizadas = pizzasPersonalizadas;
            Estado = EstadoPedido.RECIBIDO;
        }

    }
}

