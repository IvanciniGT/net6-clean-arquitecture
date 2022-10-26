using Telepi.Application.Entities.Pedidos.Commands;
using Telepi.Application.Commons.Mediator;
using Telepi.Application.Commons.Maps;
using Telepi.Business.Commons;
using Telepi.Business.Entities;
using Telepi.Business.ValueObjects;
using Telepi.Application.Dtos;
using Telepi.Application.Commons.DBContext;

namespace Telepi.Application.Entities.Pedidos.Handlers;

public abstract class AbstractHandler: ICommandHandler
{
    private static bool inicializado = false;

    public AbstractHandler()
    {
        if (!inicializado) subscribe();
    }

    public abstract Respuesta handle(ICommand comando);

    protected abstract void subscribe();

}

