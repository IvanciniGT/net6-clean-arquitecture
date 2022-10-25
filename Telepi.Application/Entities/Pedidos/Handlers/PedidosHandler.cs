using Telepi.Application.Entities.Pedidos.Commands;
using Telepi.Application.Commons.Mediator;
using Telepi.Business.Commons;
using Telepi.Business.Entities;
using Telepi.Business.ValueObjects;
using Telepi.Application.Dtos;
using Telepi.Application.Commons.DBContext;

namespace Telepi.Application.Entities.Pedidos.Handlers;

public class PedidosHandler : ICommandHandler<PedidoDTO>
{

    private IDBContext contexto;
    private IMediador mediador;
    private IMediadorComandos mediadorComandos;

    public PedidosHandler(IDBContext contexto, IMediador mediador, IMediadorComandos mediadorComandos)
    {
        this.contexto = contexto;
        this.mediador = mediador;
        this.mediadorComandos = mediadorComandos;
        this.mediadorComandos.subscribe( this );
    }

    //public void handle(ICommand comando)
    //{

    public Respuesta<PedidoDTO> handle(ICommand comando)
    {
        // CASE !
        return NuevoPedido((NuevoPedidoCommand)comando);
    }

    private Respuesta<PedidoDTO> NuevoPedido(NuevoPedidoCommand comando)
    {
        IReadOnlyCollection<PizzaPersonalizada> pizzasAIncluir;// = comando.pizzas; Lo podré hacer con un mapper
        // El problema de usar un automapper es que o convierto el objeto en mutable
        // o me curro la configuración del mapeo a través del construcutor
        // Si monto yo el mapeo... me quito de ese problema
        Pedido nuevoPedido;// = new Pedido(mediador, comando.cliente, pizzasAIncluir);
        PedidoDTO nuevoPedidoDTO;// new PedidoDTO( mediador, comando.cliente, pizzasAIncluir);
        int id= contexto.persistir(nuevoPedidoDTO);
        //nuevoPedido.Id = id;
        return new Respuesta<PedidoDTO>(nuevoPedidoDTO);
    }

}