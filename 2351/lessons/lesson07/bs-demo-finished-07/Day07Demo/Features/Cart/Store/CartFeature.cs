using Fluxor;

namespace Day07Demo.Features.Cart.Store;

public class CartFeature : Feature<CartState>
{
    public override string GetName() => "Cart";

    protected override CartState GetInitialState() => new();
}
