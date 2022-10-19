using Telepi.Business.Commons;
namespace Telepi.Business.ValueObjects;

public class Pizza : ValueObject
{

    public IReadOnlyCollection<Ingrediente> Ingredientes { get; private set; }

    public Masa Masa { get; private set; }


    public Pizza(IReadOnlyCollection<Ingrediente> ingredientes, Masa masa)
    {
        Ingredientes = ingredientes;
        Masa = masa;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Masa;
        yield return Ingredientes;
    }
}

