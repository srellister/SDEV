using Fluxor;

namespace Day07Practice.Features.User.Store;

public static class UserReducers
{
    [ReducerMethod]
    public static UserState ReduceSetUserRoleAction(UserState state, SetUserRoleAction action)
    {
        return state with { Role = action.Role };
    }
}
