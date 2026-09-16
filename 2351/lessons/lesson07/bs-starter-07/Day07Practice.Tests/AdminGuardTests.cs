using Day07Practice.Features.User.Store;

namespace Day07Practice.Tests;

// PRACTICE 2, part 2: write ONE test for the guard you just extracted.
//
// The test project, the reference to Day07Practice, and the xUnit wiring are all set up --
// you only write the test method. Once AdminGuard exists, uncomment the using below and
// delete this comment block.
//
// using Day07Practice.Guards;

public class AdminGuardTests
{
    // TODO: Write a test named ShouldRedirect_WhenRoleIsNotAdmin_ReturnsTrue
    //   Arrange: var state = new UserState { Role = "User" };
    //   Act:     call AdminGuard.ShouldRedirect(state)
    //   Assert:  Assert.True(...)
    //
    // Stretch: write the other direction too -- Role = "Admin" must return false.
    // A guard that always returned true would still pass the first test on its own.
}
