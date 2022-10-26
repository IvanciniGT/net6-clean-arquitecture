using Microsoft.AspNetCore.Mvc;
using Telepi.API.Dtos;
using Telepi.Application.Entities.Pedidos.Commands;
using Telepi.Application.Commons.Mediator;
using Telepi.Application.Dtos;
using Telepi.Business.Enums;
using Telepi.Business.ValueObjects;
using System.Linq;
using Telepi.API.Commons.Maps;

namespace Telepi.API.Controllers;

[ApiController]
[Route("[controller]")]
public class PedidosController : ControllerBase
{

    IMediadorComandos mediadorComandos;

    public PedidosController(IMediadorComandos mediadorComandos) {
        this.mediadorComandos = mediadorComandos;
    }

    [HttpPost]
    public IActionResult NuevoPedido(PedidoRequestDTO datosPedido)
    {
        // Validar datos del pedido se hace en capa 2 y 1
        ICommand realizarPedido = new NuevoPedidoCommand(datosPedido.Cliente, DTOsMappings.createPizzasDTO(datosPedido.Pizzas));
        Respuesta<PedidoDTO> respuesta = mediadorComandos.execute<PedidoDTO>(realizarPedido);
        
        // A mapear otra vez!
        return respuesta.exito==EstadoRespuestaComando.SUCCESS ? Ok(DTOsMappings.createPedidoResponseDTO(respuesta.valor))
                :BadRequest(respuesta.exception.Message)
                ;
    }
    /*
    [HttpGet]
    public IActionResult RecuperarPedidos()
    {
        return Ok(pedidos);
    }
    */
}

