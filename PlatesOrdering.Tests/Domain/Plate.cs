using Ardalis.GuardClauses;
using System.Diagnostics.CodeAnalysis;

namespace PlatesOrdering.Tests.Domain;

public class Plate
{
    public decimal _basePrice;
    public virtual decimal Price => _basePrice;

    public Plate(decimal price)
    {
        Guard.Against.NegativeOrZero(price);
        _basePrice = price;
    }
}