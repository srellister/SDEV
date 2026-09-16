namespace Day07Practice.Features.User.Store;

public record UserState
{
    public string Role { get; init; } = "User";
    public string UserName { get; init; } = "Guest";
}
