﻿using System.Diagnostics.CodeAnalysis;

namespace PlatesOrdering.Tests.Domain;

public class Wok : Plate
{
    private List<Sauce> _sauces = new();
    private List<Ingredient> _ingredients = new();

    public IReadOnlyCollection<Sauce> Sauces => _sauces.AsReadOnly();
    public IReadOnlyCollection<Ingredient> Ingredients => _ingredients.AsReadOnly();

    public void AddSauce(Sauce sauce) => _sauces.Add(sauce);
    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);

    public Wok(decimal price) : base(price) { }
}
