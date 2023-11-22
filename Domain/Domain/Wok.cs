using Ardalis.GuardClauses;

namespace Domain.Domain;

public class Wok : Plate
{
    private List<Sauce> _sauces = new();
    private List<Ingredient> _ingredients = new();

    public IReadOnlyCollection<Sauce> Sauces => _sauces.AsReadOnly();
    public IReadOnlyCollection<Ingredient> Ingredients => _ingredients.AsReadOnly();

    public override decimal Price => base.Price + Ingredients.Sum(d => d.Price);

    public void AddSauce(Sauce sauce) => _sauces.Add(sauce);
    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);

    public Wok(string name, decimal price, Sauce sauce, Ingredient ingredient) : base(name, price) 
    {
        AddSauce(sauce);
        AddIngredient(ingredient);
    }

    internal Wok()
    {
        
    }
}
