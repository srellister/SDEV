using Day07Demo.Models;

namespace Day07Demo.Features.Cart.Store;

public record CartState
{
    public IReadOnlyList<CartItem> Items { get; init; } = [];
    public bool IsLoading { get; init; }
    public string? ErrorMessage { get; init; }
}
