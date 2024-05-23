namespace AlchemyLub.Florist.Core.Models.Goods;

/// <summary>
/// Composition of various balloons.
/// </summary>
public record BalloonComposition(IReadOnlyCollection<Balloon> Balloons, decimal Price) : IProduct
{
    public ProductType Type => ProductType.Balloons;
}
