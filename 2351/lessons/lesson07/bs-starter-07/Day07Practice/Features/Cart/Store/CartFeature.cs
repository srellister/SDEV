using Fluxor;

namespace Day07Practice.Features.Cart.Store;

public class CartFeature : Feature<CartState>
{
    public override string GetName() => "Cart";

    protected override CartState GetInitialState() => new();
}
