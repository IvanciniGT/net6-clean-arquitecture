using Telepi.Business.Commons;
using Telepi.Business.Enums;
using Telepi.Business.ValueObjects;

namespace Telepi.Business.Entities
{
    public class Pizza
    {

        public int Id { get;  set; }
        public PizzaPersonalizada PizzaPersonalziada { get; set; }
        public Pedido Pedido { get; set; }

        public Pizza()
        {
            // TODO: Revisar id... si se calcula en automatico si no se pasa.... y si permito pasarlo}
        }
        public Pizza(int id, PizzaPersonalizada pizzaPersonalziada, Pedido pedido)
        {
            Id = id;
            PizzaPersonalziada = pizzaPersonalziada;
            Pedido = pedido;
        }

    }
}

