using Ardalis.GuardClauses;
using System.Diagnostics.CodeAnalysis;

namespace Domain.Domain;

public class Sauce
{
    public required decimal Price { get; init; }

    public Guid Id { get; init; }

    [SetsRequiredMembers]
    public Sauce(decimal price)
    {
        Guard.Against.NegativeOrZero(price);
        Price = price;
    }

    public Sauce()
    {
        
    }
}