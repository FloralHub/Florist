namespace FloralHub.Florist.Core.Models;

/// <summary>
/// Store customer.
/// </summary>
public record Customer
{
    public Guid Id { get; init; }

    public string Name { get; init; } = string.Empty;

    public string Address { get; init; } = string.Empty;

    public string City { get; init; } = string.Empty;

    public string Phone { get; init; } = string.Empty;
}
