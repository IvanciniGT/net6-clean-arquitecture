using Telepi.Business.Enums;
using Telepi.Business.ValueObjects;

namespace Telepi.Application.Dtos;

public class PizzaPersonalizadaDTO
{

    public ConceptoDePizza ConceptoDePizza { get; private set; }

    public Tamano Tamano { get; private set; }

    public PizzaPersonalizadaDTO(ConceptoDePizza ConceptoDePizza, Tamano Tamano) { }

}

