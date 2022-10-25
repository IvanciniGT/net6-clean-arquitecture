using Telepi.Business.Enums;
using Telepi.Business.ValueObjects;

namespace Telepi.Application.Dtos;

public class PizzaDTO: IDTO
{
    public int Id { get; set; }

    public ConceptoDePizza ConceptoDePizza { get;  set; }

    public Tamano Tamano { get;  set; }

}

