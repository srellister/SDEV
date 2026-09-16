using BYSResults;
using Day07Practice.Models;

namespace Day07Practice.Services;

public class MockCartService : ICartService
{
    public async Task<Result<List<CartItem>>> GetCartItemsAsync()
    {
        await Task.Delay(200);
        var result = new Result<List<CartItem>>();
        return result.WithValue([]);
    }
}
