using Telepi.Business.Commons;
using Telepi.Business.Enums;

namespace Telepi.Business.ValueObjects;

public class Masa : ValueObject
{
    public TipoMasa Tipo { get; private set; }
    // TODO: Meter alergenos y Cantidad a utilizar al crear una pizza


    public Masa(TipoMasa tipo)
    {
        Tipo = tipo;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Tipo;
    }
}
