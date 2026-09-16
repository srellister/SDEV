namespace Day05Demo.Features.Product.Store;

// [PRE-BUILT -- narrate, do not type] (Demonstration, Step 1)
// The three actions of the triple-action pattern are ALREADY WRITTEN below --
// these are the real shapes, identical to the finished project. Nothing here
// gets typed live. Open the file, point at each record, and explain its role:
//   - LoadProductsAction         -- trigger, carries no data
//   - LoadProductsSuccessAction  -- carries List<Services.Product> Products
//   - LoadProductsFailureAction  -- carries string Error

// Trigger -- dispatched by the component to start loading
public record LoadProductsAction;

// Success -- dispatched by the effect when data arrives
public record LoadProductsSuccessAction(List<Services.Product> Products);

// Failure -- dispatched by the effect when the service call fails
public record LoadProductsFailureAction(string Error);
