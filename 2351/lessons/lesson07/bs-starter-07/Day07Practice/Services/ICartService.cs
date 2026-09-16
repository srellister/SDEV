using BYSResults;
using Day07Practice.Models;

namespace Day07Practice.Services;

public interface ICartService
{
    Task<Result<List<CartItem>>> GetCartItemsAsync();
}
