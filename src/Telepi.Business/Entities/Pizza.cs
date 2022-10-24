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

        private bool _lista;
        public bool Lista
        {
            get => _lista;
            set
            {
                _lista = value;
                if (_lista)
                {
                    Pedido.notificarQueLaPizzaEstaLista();
                }
            }
        }

        public Pizza(int id, PizzaPersonalizada pizzaPersonalziada, Pedido pedido)
        {
            Lista = false;
            Id = id;
            PizzaPersonalziada = pizzaPersonalziada;
            Pedido = pedido;
        }

    }
}

