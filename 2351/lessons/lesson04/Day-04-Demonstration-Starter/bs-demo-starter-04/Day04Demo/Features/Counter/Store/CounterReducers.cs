namespace Day04Demo.Features.Counter.Store;

using Fluxor;

// TODO: Define a public static class CounterReducers with three reducer methods:
//
// 1. ReduceIncrementCounterAction -- return state with { Count = state.Count + 1 }
// 2. ReduceDecrementCounterAction -- return state with { Count = state.Count - 1 }
// 3. ReduceSetCounterAction -- return state with { Count = action.NewCount }
//
// Each method must be:
//   - public static
//   - decorated with [ReducerMethod]
//   - take (CounterState state, XxxAction action) as parameters
//   - return a NEW CounterState using the 'with' expression
//
// Reducers are pure functions: same input always produces the same output.
// No side effects, no async, no DI.
 public static class CounterReducers
{
    [ReducerMethod]
    public static CounterState ReduceIncrementCounterAction(
        CounterState state,
        IncrementCounterAction action)
    {
        return state with { Count = state.Count +1};
    }

    [ReducerMethod]

    public static CounterState ReduceDecrementCounterAction(
        CounterState state,
        DecrementCounterAction action)
    {
        return state with { Count = state.Count - 1};
    }

    [ReducerMethod]

    public static CounterState ReduceSetCounterAction(
        CounterState state,
        SetCounterAction action)
    {
        return state with { Count = action.NewCount};
    }
}