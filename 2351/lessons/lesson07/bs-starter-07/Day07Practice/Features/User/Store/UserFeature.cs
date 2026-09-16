using Fluxor;

namespace Day07Practice.Features.User.Store;

public class UserFeature : Feature<UserState>
{
    public override string GetName() => "User";

    protected override UserState GetInitialState() => new();
}
