using Fluxor;

namespace Day05Demo.Features.Product.Store;

public static class ProductReducers
{
    // TODO (Demonstration, Step 3): Write the three reducers of the triple-action pattern.
    //   - ReduceLoadProductsAction        -> state with { IsLoading = true, ErrorMessage = null }
    //   - ReduceLoadProductsSuccessAction -> state with { Items = action.Products, IsLoading = false }
    //   - ReduceLoadProductsFailureAction -> state with { ErrorMessage = action.Error, IsLoading = false }
    // Each reducer needs the [ReducerMethod] attribute. Reducers stay pure --
    // no async, no service calls. The placeholder bodies below keep the project
    // compiling; the instructor replaces them with the real `state with { ... }`
    // expressions while narrating.

    [ReducerMethod]
    public static ProductState ReduceLoadProductsAction(ProductState state, LoadProductsAction action)
        => state;

    [ReducerMethod]
    public static ProductState ReduceLoadProductsSuccessAction(ProductState state, LoadProductsSuccessAction action)
        => state;

    [ReducerMethod]
    public static ProductState ReduceLoadProductsFailureAction(ProductState state, LoadProductsFailureAction action)
        => state;
}
