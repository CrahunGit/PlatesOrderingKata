using Ardalis.GuardClauses;
using System.Diagnostics.CodeAnalysis;

namespace Domain.Domain;

public class Ingredient
{
    public Guid Id { get; set; }

    public required decimal Price { get; init; }

    [SetsRequiredMembers]
    public Ingredient(decimal price)
    {
        Guard.Against.NegativeOrZero(price);
        Price = price;
    }

    internal Ingredient()
    {
        
    }
}
