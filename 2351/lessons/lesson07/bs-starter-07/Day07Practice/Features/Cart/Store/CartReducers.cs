using Fluxor;

namespace Day07Practice.Features.Cart.Store;

public static class CartReducers
{
    [ReducerMethod]
    public static CartState ReduceAddToCartAction(CartState state, AddToCartAction action)
    {
        var existingItem = state.Items.FirstOrDefault(i => i.Name == action.Item.Name);
        if (existingItem is not null)
        {
            var updatedItems = state.Items
                .Select(i => i.Name == action.Item.Name
                    ? i with { Quantity = i.Quantity + action.Item.Quantity }
                    : i)
                .ToList();
            return state with { Items = updatedItems };
        }

        return state with { Items = [.. state.Items, action.Item] };
    }

    [ReducerMethod]
    public static CartState ReduceRemoveFromCartAction(CartState state, RemoveFromCartAction action)
    {
        var updatedItems = state.Items
            .Where(i => i.Name != action.ItemName)
            .ToList();
        return state with { Items = updatedItems };
    }

    [ReducerMethod(typeof(ClearCartAction))]
    public static CartState ReduceClearCartAction(CartState state)
    {
        return state with { Items = [] };
    }
}
