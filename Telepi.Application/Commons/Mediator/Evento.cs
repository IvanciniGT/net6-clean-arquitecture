using Telepi.Business.Entities;
using Telepi.Business.Enums;

namespace Telepi.Application.Commons.Mediator;

public class Evento
{

    public Guid PedidoId { get; internal set; }
    public int NuevoEstado { get; internal set; }

}
