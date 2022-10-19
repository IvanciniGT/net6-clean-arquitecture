using Telepi.Business.Commons;
using Telepi.Business.Enums;

namespace Telepi.Business.ValueObjects
{
    public class Descuento : ValueObject
    {

        public double Cantidad { get; private set; }
        public bool EsAbsoluta { get; private set; }


        public Descuento(double cantidad, bool esAbsoluta)
        {
            Cantidad = cantidad;
            EsAbsoluta = esAbsoluta;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Cantidad;
            yield return EsAbsoluta;
        }
    }
}

