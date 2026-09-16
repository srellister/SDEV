namespace Day04Demo.Features.Counter.Store;

using Fluxor;

// TODO: Define a public class CounterFeature that inherits Feature<CounterState>
//
// Override two methods:
//   - GetName() => "Counter"  (label for Redux DevTools)
//   - GetInitialState() => new CounterState { Count = 0 }  (starting value)
//
// One Feature class per state type. This registers the state with Fluxor.

public class CounterFeature : Feature<CounterState>
{
    public override string GetName() => "Counter";

    protected override CounterState GetInitialState()
    {
        return new CounterState { Count = 0 };
    }

}