using Telepi.Business.Commons;

namespace Telepi.Business.ValueObjects;

public class Ingrediente : ValueObject
{
    public String Nombre { get; private set; }
    // TODO: Meter alergenos y Cantidad a utilizar al crear una pizza


    public Ingrediente(string nombre)
    {
        Nombre = nombre;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Nombre;
    }
}
