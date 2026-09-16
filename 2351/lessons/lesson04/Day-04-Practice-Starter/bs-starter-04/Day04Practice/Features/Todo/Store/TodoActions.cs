namespace Day04Practice.Features.Todo.Store;

// TODO: Define two action records:
//
// 1. AddTodoAction(string Title) -- carries the title of the new todo
// 2. RemoveTodoAction(int Id) -- carries the Id of the todo to remove
//
// Pattern: public record ActionName(parameters);

// PRE-BUILT -- the third action ships written, and so does its reducer. Toggle is the
// worked example for immutable list replacement: read it, then apply the same shape to
// Remove. See TodoReducers.ReduceToggleTodoAction.
public record ToggleTodoAction(int Id);

public record AddTodoAction(string Title);

public record RemoveTodoAction(int Id);