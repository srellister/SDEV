using Day07Demo.Features.Cart.Store;

namespace Day07Demo.Guards;

// The guard CONDITION lifted out of Checkout.razor into a plain static class. Why extract
// it: a component can only be exercised by rendering it, but a pure predicate is a one-line
// unit test — ShouldRedirect(emptyCart) must be true, ShouldRedirect(fullCart) false. Same
// decision, now verifiable without the UI. The component keeps the side effect (NavigateTo);
// the guard owns only the pure "should we redirect?" question — that split is what makes it
// testable.
public static class CartGuard
{
    public static bool ShouldRedirect(CartState state) =>
        state.Items.Count == 0;
}
