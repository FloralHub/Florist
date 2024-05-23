namespace AlchemyLub.Florist.Core.Models.Abstractions;

public interface IProduct
{
    public decimal Price { get; init; }

    public ProductType Type { get; }
}
