using Telepi.Application.Dtos;
using Telepi.Application.Commons.Mediator;
namespace Telepi.Application.Entities.Pedidos.Commands;

public class NuevoPedidoCommand: ICommand
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

