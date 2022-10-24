using Telepi.Application.Dtos;
namespace Telepi.Application.Entities.Pedidos.Commands;

public class NuevoPedidoCommand
{
    public String cliente { get; private set; }
    public IReadOnlyList<PizzaPersonalizadaDTO> pizzas { get; private set; }

//    public NuevoPedidoCommand() {
//    }

    public NuevoPedidoCommand(String cliente, IReadOnlyList<PizzaPersonalizadaDTO> pizzas) {
        this.cliente = cliente;
        this.pizzas = pizzas;
    }
}

