using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.SignalR;

namespace Day04Demo.Features.Counter.Store;

// TODO: Define CounterState as a record (not a class) with one property:
//   - int Count { get; init; }
//
// Use 'record' for value equality and the 'with' expression.
// Use 'init' (not 'set') to enforce immutability -- state can only be
// set during construction, never mutated directly.
public record CounterState
{
    public int Count { get; init; }
}