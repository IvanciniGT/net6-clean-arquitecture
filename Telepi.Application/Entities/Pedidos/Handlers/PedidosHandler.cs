using Telepi.Application.Entities.Pedidos.Commands;
using Telepi.Application.Commons.Mediator;
using Telepi.Application.Commons.Maps;
using Telepi.Business.Commons;
using Telepi.Business.Entities;
using Telepi.Business.ValueObjects;
using Telepi.Application.Dtos;
using Telepi.Application.Commons.DBContext;

namespace Telepi.Application.Entities.Pedidos.Handlers;
public interface IPedidosHandler : ICommandHandler
{
}

public class PedidosHandler : AbstractHandler, IPedidosHandler
{

    private IRepositorio contexto;
    private IMediador mediador;
    private IMediadorComandos mediadorComandos;

    public PedidosHandler(IRepositorio contexto, IMediadorEventos mediador, IMediadorComandos mediadorComandos)
    {
        this.contexto = contexto;
        this.mediador = mediador;
        this.mediadorComandos = mediadorComandos;
    }

    protected override void subscribe() {
        this.mediadorComandos.subscribeToComand<PedidosHandler, NuevoPedidoCommand>();
    }

    //public void handle(ICommand comando)
    //{

    public override Respuesta handle(ICommand comando)
    {
        // CASE !
        return NuevoPedido((NuevoPedidoCommand)comando);
    }

    private Respuesta NuevoPedido(NuevoPedidoCommand comando)
    {
        IReadOnlyCollection<PizzaPersonalizada> pizzasAIncluir = DTOsMappings.createPizzasPersonalizadas(comando.pizzas);
        // El problema de usar un automapper es que o convierto el objeto en mutable
        // o me curro la configuración del mapeo a través del construcutor
        // Si monto yo el mapeo... me quito de ese problema

        // Que necesito de partida? Un ID DE PEDIDO
        //try
        //{
        Pedido nuevoPedido = new Pedido(mediador, comando.cliente, pizzasAIncluir);
        //}// Controlar posibles ostiones
        PedidoDTO nuevoPedidoDTO = DTOsMappings.createPedidoDTO(nuevoPedido);
        //try
        //{
        // Potencial sitio para otro mediador. Habitual en CQRS
        contexto.persistir(nuevoPedidoDTO);
        contexto.SaveChanges();
        //}
        nuevoPedido.Id = nuevoPedidoDTO.Id;
        //mediadorComandos.commitCommando(comando); Para reprocesar pedidos que en los que se haya producido un error sin perderlos
        return new Respuesta(nuevoPedidoDTO);
    }

}