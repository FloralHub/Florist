namespace AlchemyLub.Florist.Core.Models.Goods;

public record Toy(IReadOnlyCollection<Flower> Flowers, decimal Price) : IProduct
{
    public ProductType Type => ProductType.Toy;
}
