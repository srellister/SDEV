namespace Day04Demo.Features.Counter.Store;

// TODO: Define three action records:
//
// 1. IncrementCounterAction -- parameterless signal
// 2. DecrementCounterAction -- parameterless signal
// 3. SetCounterAction(int NewCount) -- carries the target value
//
// Actions are record types that describe WHAT HAPPENED.
// Naming convention: Verb + Noun + "Action"

public record IncrementCounterAction;

public record DecrementCounterAction;
public record SetCounterAction(int NewCount);