using Ardalis.GuardClauses;

namespace Domain.Domain;

public class Plate
{
    public Guid Id { get; init; }
    public string Name { get; init; }

    public virtual decimal Price { get; init; } 

    public Plate(string name, decimal price)
    {
        Guard.Against.NegativeOrZero(price);
        Price = price;
        Name = name;
    }

    internal Plate()
    {
        
    }
}