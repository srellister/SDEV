using Day07Practice.Models;

namespace Day07Practice.Features.Cart.Store;

public record AddToCartAction(CartItem Item);
public record RemoveFromCartAction(string ItemName);
public record ClearCartAction;
