
using Telepi.API.Dtos;
using Telepi.Application.Dtos;

namespace Telepi.API.Commons.Maps;


public static class DTOsMappings
{
    public static IReadOnlyList<PizzaDTO> createPizzasDTO(IReadOnlyCollection<PizzaHttpDTO> pizzasRequest)
    {
        return pizzasRequest.Select(createPizzaDTO).ToArray();
    }

    public static PizzaDTO createPizzaDTO(PizzaHttpDTO pizzaRequest)
    {
        PizzaDTO pizza = new PizzaDTO();
        pizza.Ingredientes = pizzaRequest.Ingredientes;
        pizza.Masa = pizzaRequest.Masa;
        pizza.Tamano = pizzaRequest.Tamano;
        return pizza;
    }

    internal static PedidoResponseDTO createPedidoResponseDTO(PedidoDTO? valor)
    {
        throw new NotImplementedException();
    }
}

