using Day07Practice.Models;

namespace Day07Practice.Features.Cart.Store;

public record CartState
{
    public IReadOnlyList<CartItem> Items { get; init; } = [];
    public bool IsLoading { get; init; }
    public string? ErrorMessage { get; init; }
}
