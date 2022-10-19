using Telepi.Business.Commons;
using Telepi.Business.Enums;
using Telepi.Business.ValueObjects;

namespace Telepi.Business.Entities
{
    public class PizzaPredisenada 
    {

        public int Id { get;  set; }
        public string Nombre { get;  set; }
        public Pizza Pizza { get;  set; }

        public PizzaPredisenada()
        {
            // TODO: Revisar id... si se calcula en automatico si no se pasa.... y si permito pasarlo}
        }
        public PizzaPredisenada(int id, string nombre, Pizza pizza)
        {
            Id = id;
            Pizza = pizza;
            Nombre = nombre;
        }

    }
}

