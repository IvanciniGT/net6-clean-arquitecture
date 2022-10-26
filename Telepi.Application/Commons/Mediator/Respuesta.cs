using System;
namespace Telepi.Application.Commons.Mediator
{
    public class Respuesta
    {
        public Object valor { get; private set; }
        public EstadoRespuestaComando exito { get; private set; }
        public Exception? exception { get; private set; }

        internal Respuesta(Object valor)
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

