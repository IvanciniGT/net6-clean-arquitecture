using Telepi.Business.Commons;
using Telepi.Business.Enums;
using Telepi.Business.ValueObjects;

namespace Telepi.Business.Entities
{
    public class PizzaPredisenada
    {

        public int Id { get;  set; }
        public string Nombre { get;  set; }
        public ConceptoDePizza Pizza { get;  set; }

        public PizzaPredisenada(int id, string nombre, ConceptoDePizza pizza)
        {
            Id = id;
            Pizza = pizza;
            Nombre = nombre;
        }

    }
}

