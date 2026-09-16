namespace Day07Practice.Features.Form.Store;

public record FormState
{
    public IReadOnlySet<int> CompletedSteps { get; init; } = new HashSet<int>();
}
