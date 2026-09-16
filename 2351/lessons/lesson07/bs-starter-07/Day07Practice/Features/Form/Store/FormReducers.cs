using Fluxor;

namespace Day07Practice.Features.Form.Store;

public static class FormReducers
{
    [ReducerMethod]
    public static FormState ReduceCompleteStepAction(FormState state, CompleteStepAction action)
    {
        var updatedSteps = new HashSet<int>(state.CompletedSteps) { action.Step };
        return state with { CompletedSteps = updatedSteps };
    }
}
