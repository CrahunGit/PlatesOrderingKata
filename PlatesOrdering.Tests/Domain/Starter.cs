using Ardalis.GuardClauses;

namespace PlatesOrdering.Tests.Domain;

public class Starter : Plate
{
    private List<Sauce> _sauces = new();

    public IReadOnlyCollection<Sauce> Sauces => _sauces.AsReadOnly();

    public override decimal Price => base.Price + Sauces.Take(Sauces.Count - FreeSauces).Sum(d => d.Price);

    public int FreeSauces { get; init; }

    public Starter(decimal price, int freeSauces) : base(price)
    {
        Guard.Against.NegativeOrZero(freeSauces);
        FreeSauces = freeSauces;
    }

    public void AddSauce(Sauce sauce) => _sauces.Add(sauce);
}
