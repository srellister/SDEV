using Day07Demo.Models;

namespace Day07Demo.Features.Cart.Store;

public record AddToCartAction(CartItem Item);
public record RemoveFromCartAction(string ItemName);
public record ClearCartAction;
