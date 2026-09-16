using Fluxor;

namespace Day07Practice.Features.Form.Store;

public class FormFeature : Feature<FormState>
{
    public override string GetName() => "Form";

    protected override FormState GetInitialState() => new();
}
