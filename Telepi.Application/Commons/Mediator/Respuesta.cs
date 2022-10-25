using System;
namespace Telepi.Application.Commons.Mediator
{
    public class Respuesta<T>
    {
        public T? valor { get; private set; }
        public EstadoRespuestaComando exito { get; private set; }
        public Exception? exception { get; private set; }

        internal Respuesta(T valor)
        {
            this.valor = valor;
            this.exito = EstadoRespuestaComando.SUCCESS;
        }

        internal Respuesta(EstadoRespuestaComando exito,Exception exception)
        {
            this.exito = exito;
            this.exception = exception;
        }
    }

}

