using Ardalis.GuardClauses;
using System.Diagnostics.CodeAnalysis;

namespace PlatesOrdering.Tests.Domain;

public class Sauce
{
    public required decimal Price { get; init; }

    [SetsRequiredMembers]
    public Sauce(decimal price)
    {
        Guard.Against.NegativeOrZero(price);
        Price = price;
    }
}