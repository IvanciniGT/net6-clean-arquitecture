
using System.Collections.Generic;
using Telepi.Application.Dtos;
using Telepi.Business.Enums;
using Telepi.Business.Entities;
using Telepi.Business.ValueObjects;

namespace Telepi.Application.Commons.Maps;


public static class DTOsMappings
{
    public static IReadOnlyCollection<PizzaPersonalizada> createPizzasPersonalizadas(IReadOnlyList<PizzaDTO> pizzasDTO)
    {
        return pizzasDTO.Select(createPizzaPersonalizada).ToArray();
    }

    public static PizzaPersonalizada createPizzaPersonalizada(PizzaDTO pizzaDTO)
    {
        IReadOnlyCollection<Ingrediente> Ingredientes = pizzaDTO.Ingredientes
                .Select<string, Ingrediente>(ingrediente => new Ingrediente(ingrediente)).ToArray();
        ConceptoDePizza conceptoDePizza = new ConceptoDePizza(Ingredientes, new Masa((TipoMasa)pizzaDTO.Masa));
        
        PizzaPersonalizada pizza = new PizzaPersonalizada(conceptoDePizza, (Tamano)pizzaDTO.Tamano);
         
         
        return pizza;
    }



    public static PedidoDTO createPedidoDTO(Pedido nuevoPedido) 
    {
        PedidoDTO nuevoPedidoDTO = new PedidoDTO();
        nuevoPedidoDTO.Cliente = nuevoPedido.Cliente;
        nuevoPedidoDTO.Estado = nuevoPedido.Estado;
        nuevoPedidoDTO.Pizzas = nuevoPedido.PizzasPersonalizadas.Select(
            pizza => {
                PizzaDTO pizzaDTO = new PizzaDTO();
                pizzaDTO.Ingredientes = pizza.ConceptoDePizza.Ingredientes.Select(
                        ingrediente => ingrediente.Nombre).ToArray();
                pizzaDTO.Masa = (int)pizza.ConceptoDePizza.Masa.Tipo;
                pizzaDTO.Tamano = (int)pizza.Tamano;
                return pizzaDTO;
            }
            ).ToArray();
        return nuevoPedidoDTO;
    }
}

