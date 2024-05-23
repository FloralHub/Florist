namespace AlchemyLub.Florist.Core.Models.Goods;

/// <summary>
/// Flower bouquet.
/// </summary>
/// <param name="Flowers">Flowers included in the bouquet.</param>
/// <param name="Price">Bouquet cost.</param>
public record Bouquet(IReadOnlyCollection<Flower> Flowers, decimal Price) : IProduct
{
    public ProductType Type => ProductType.Bouquet;
}
