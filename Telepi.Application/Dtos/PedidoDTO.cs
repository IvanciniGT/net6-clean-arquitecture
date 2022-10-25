using Telepi.Business.Commons;
using Telepi.Business.Enums;
using Telepi.Business.Events;
using Telepi.Business.Exceptions;
using Telepi.Business.ValueObjects;

namespace Telepi.Application.Dtos  // POCO 
{
    public class PedidoDTO : IDTO
    {
        public int Id { get; set; }
        public string Cliente { get;  set; }
        public EstadoPedido Estado { get;  set; }
        public IReadOnlyCollection<PizzaDTO> Pizzas { get;  set; }

    }
}

