using Domain.Domain;
using FluentAssertions;

namespace PlatesOrdering.Tests;

public class OrderSpecification
{
    [Fact]
    public void Wok_plate_should_contain_one_ingredient_at_least()
    {
        //Act
        var orderingPlates = GetOrderingWokPlate();

        //Assert
        orderingPlates.Ingredients.Should().HaveCountGreaterThanOrEqualTo(1);
    }

    [Fact]
    public void Wok_plate_should_contain_one_sauce_at_least()
    {
        //Act
        var orderingPlates = GetOrderingWokPlate();

        //Assert
        orderingPlates.Sauces.Should().HaveCountGreaterThanOrEqualTo(1);
    }

    [Fact]
    public void Closed_plate_should_costs_base_price()
    {
        //Act
        var orderingPlates = GetOrderingClosedPlate(12.25m);

        //Assert
        orderingPlates.Price.Should().Be(12.25m);
    }

    [Fact]
    public void Starter_plate_should_costs_base_price_sauces_price_discounting_free_sauces()
    {
        //Act
        var orderingPlates = GetOrderingStarterPlateWith2Sauces(price: 12.25m, freeSauces: 1);

        //Assert
        orderingPlates.Price.Should().Be(13.25m);
    }

    private Wok GetOrderingWokPlate()
    {
        var plate = new Wok("wok", 1);
        plate.AddSauce(new Sauce(price: 1));
        plate.AddIngredient(new Ingredient());
        return plate;
    }

    private Closed GetOrderingClosedPlate(decimal price)
    {
        var plate = new Closed("Closed", price);
        return plate;
    }

    private Starter GetOrderingStarterPlateWith2Sauces(decimal price, int freeSauces)
    {
        var plate = new Starter("Starter", price, freeSauces);
        plate.AddSauce(new Sauce(price: 1));
        plate.AddSauce(new Sauce(price: 1));
        return plate;
    }
}