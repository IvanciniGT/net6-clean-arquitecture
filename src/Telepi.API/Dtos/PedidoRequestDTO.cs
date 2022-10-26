using System;
namespace Telepi.API.Dtos
{
    public class PedidoRequestDTO
    {
        public string Cliente { get; set; }
        public IReadOnlyCollection<PizzaHttpDTO> Pizzas { get; set; }

    }
}

