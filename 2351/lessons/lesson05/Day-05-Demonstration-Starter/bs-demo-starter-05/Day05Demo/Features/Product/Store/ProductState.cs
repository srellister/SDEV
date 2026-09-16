namespace Day05Demo.Features.Product.Store;

// [PRE-BUILT -- narrate, do not type] (Demonstration, Step 2)
// The state properties the async lifecycle needs are ALREADY WRITTEN below --
// the real shapes, identical to the finished project. Narrate the two new
// async-lifecycle properties against Day 4's state record; do not type them:
//   - List<Services.Product> Items  (default: empty list)
//   - bool IsLoading
//   - string? ErrorMessage

public record ProductState
{
    public List<Services.Product> Items { get; init; } = [];
    public bool IsLoading { get; init; }
    public string? ErrorMessage { get; init; }
}
