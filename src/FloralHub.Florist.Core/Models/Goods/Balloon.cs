namespace FloralHub.Florist.Core.Models.Goods;

/// <summary>
/// Hot air balloon.
/// </summary>
/// <param name="Filling">Balloon filling.</param>
/// <param name="Shape">Balloon shape.</param>
/// <param name="Color">Balloon color.</param>
public record Balloon(BalloonFilling Filling, BalloonShape Shape, BalloonColor Color);
