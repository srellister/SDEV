using Fluxor;

namespace Day05Demo.Features.Product.Store;

// [PRE-BUILT -- narrate, do not type] (Demonstration, Step 5)
// Registration with Fluxor is ALREADY WRITTEN below -- the real implementation,
// identical to the finished project. GetName() returns the feature name;
// GetInitialState() returns a fresh ProductState with empty Items,
// IsLoading = false, ErrorMessage = null. Narrate it while confirming each
// line against the Day 4 pattern; do not type it.

public class ProductFeature : Feature<ProductState>
{
    public override string GetName() => "Product";

    protected override ProductState GetInitialState()
        => new() { Items = [], IsLoading = false, ErrorMessage = null };
}
