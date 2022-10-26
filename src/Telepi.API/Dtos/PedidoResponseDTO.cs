namespace Telepi.API.Dtos;

public class PedidoResponseDTO
{
    public string Id { get; set; }
    public string Cliente { get; set; }
    public IReadOnlyCollection<PizzaHttpDTO> Pizzas { get; set; }

}

