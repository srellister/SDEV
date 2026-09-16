namespace Day04Practice.Features.Todo.Store;

using Day04Practice.Features.Todo.Models;
using Fluxor;

public static class TodoReducers
{
    // DONE!
    // TODO: Add ReduceAddTodoAction
    // 1. Generate a new Id: state.Items.Count > 0 ? state.Items.Max(t => t.Id) + 1 : 1
    // 2. Create a new TodoItem(id, action.Title, false)
    // 3. Return state with { Items = [..state.Items, newItem] };

    // TODO: Add ReduceRemoveTodoAction
    // 1. Filter out the item: state.Items.Where(t => t.Id != action.Id).ToList()
    // 2. Return state with { Items = updatedItems };

    // PRE-BUILT -- your worked example. Collection state is still IMMUTABLE: a reducer never
    // edits the existing list, it builds a NEW one. .Select(... ? item with {…} : item).ToList()
    // is a copy that replaces only the changed item. Same `with` rule as Counter, now over a
    // list of records. The two reducers above use the same idea with different LINQ shapes.
    [ReducerMethod]
    public static TodoState ReduceToggleTodoAction(
        TodoState state,
        ToggleTodoAction action)
    {
        var updatedItems = state.Items
            .Select(t => t.Id == action.Id
                ? t with { IsComplete = !t.IsComplete }
                : t)
            .ToList();
        return state with { Items = updatedItems };
    }

    [ReducerMethod]
    public static TodoState ReduceAddTodoAction(
        TodoState state,
        AddTodoAction action)
    {
        var Id = state.Items
            .Count > 0 
            ? state.Items
            .Max(t => t.Id) + 1 : 1;
        var newItem = new TodoItem(Id, action.Title, false);
        return state with {Items = [..state.Items, newItem]};
    }

    [ReducerMethod]
    public static TodoState ReduceRemoveTodoAction(
        TodoState state,
        RemoveTodoAction action)
    {
        // var updatedItems = state.Items.ToList()
        IReadOnlyList<TodoItem> updatedItems = [.. state.Items.Where(state => state.Id != action.Id)];
        return state with {Items = updatedItems};
    }
}