using Telepi.Application.Entities.Pedidos.Commands;
using Telepi.Application.Commons;
using Telepi.Business.Commons;
using Telepi.Business.Entities;
using Telepi.Business.ValueObjects;

namespace Telepi.Application.Entities.Pedidos.Handlers;

public class PedidosHandler : ICommandHandler
{

    private IRepositorio repositorio;
    private IMediador mediador;
    private IMediadorComandos mediadorComandos;

    public PedidosHandler(IRepositorio repositorio, IMediador mediador, IMediadorComandos mediadorComandos)
    {
        this.repositorio = repositorio;
        this.mediador = mediador;
        this.mediadorComandos = mediadorComandos;
        this.mediadorComandos.subscribe( this );
    }


    internal void handle(NuevoPedidoCommand comando) {
        IReadOnlyCollection<PizzaPersonalizada> pizzasAIncluir;// = comando.pizzas; Lo podré hacer con un mapper
        // El problema de usar un automapper es que convierto el objeto en mutable
        // Si monto yo el mapeo... me quito de ese problema
        Pedido nuevoPedido = new Pedido(IMediador mediador, comando.cliente, pizzasAIncluir);
        int id=repositorio.persistir(nuevoPedido);
        nuevoPedido.Id = id;

    }

}