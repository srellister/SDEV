namespace Day06Demo.Services;

public record DashboardData(int NotificationCount, int ProductCount, string UserName);

// Demo B — Step 5 [CODE LIVE]: Refactor the service contract to Result<T>.
//
// TODO Step 1: Add `using BYSResults;` at the top of this file.
// TODO Step 2: Change the return type of GetDashboardDataAsync from
//              Task<DashboardData> to Task<Result<DashboardData>>.
public interface IDashboardService
{
    Task<DashboardData> GetDashboardDataAsync();
}
