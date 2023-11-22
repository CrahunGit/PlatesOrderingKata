using FluentValidation;

namespace Web.Features.Orders;


public class DtoPlate
{
    public string Name { get; set; } = default!;
    public decimal? Price { get; set; }
}

public class Validator : AbstractValidator<DtoPlate>
{
    public Validator()
    {
        RuleFor(c => c.Name).NotEmpty();
        RuleFor(c => c.Price).NotEmpty().GreaterThan(0);
    }
}
