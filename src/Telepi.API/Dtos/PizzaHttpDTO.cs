namespace Telepi.API.Dtos;

public class PizzaHttpDTO
{
    
    public IReadOnlyCollection<string> Ingredientes { get; set; }

    public int Masa { get; set; }

    public int Tamano { get; set; }

}

