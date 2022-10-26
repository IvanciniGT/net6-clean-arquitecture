using Telepi.Business.Enums;
using Telepi.Business.ValueObjects;

namespace Telepi.Application.Dtos;

public class PizzaDTO: BaseDTO
{
    public Guid Id { get; set; }

    public IReadOnlyCollection<string> Ingredientes { get; set; }

    public int Masa { get; set; }

    public int Tamano { get;  set; }

}

