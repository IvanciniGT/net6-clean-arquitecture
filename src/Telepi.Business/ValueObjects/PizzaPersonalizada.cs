using Telepi.Business.Commons;
using Telepi.Business.Enums;

namespace Telepi.Business.ValueObjects;

public class PizzaPersonalizada : ValueObject
{

    public ConceptoDePizza ConceptoDePizza { get; private set; }

    public Tamano Tamano { get; private set; }

    //public PizzaPersonalizada() {
    //}

    public PizzaPersonalizada(ConceptoDePizza conceptoDePizza, Tamano tamano)
    {
        ConceptoDePizza = conceptoDePizza;
        Tamano= tamano;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return ConceptoDePizza;
        yield return Tamano;
    }
}

