using BYSResults;
using Day07Demo.Models;

namespace Day07Demo.Services;

public interface ICartService
{
    Task<Result<List<CartItem>>> GetCartItemsAsync();
}
