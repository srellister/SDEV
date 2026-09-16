using BYSResults;
using Day07Demo.Models;

namespace Day07Demo.Services;

public class MockCartService : ICartService
{
    public async Task<Result<List<CartItem>>> GetCartItemsAsync()
    {
        await Task.Delay(200);
        var result = new Result<List<CartItem>>();
        return result.WithValue([]);
    }
}
