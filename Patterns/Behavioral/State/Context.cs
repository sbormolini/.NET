using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State;

// The Context defines the interface of interest to clients. It also
// maintains a reference to an instance of a State subclass, which
// represents the current state of the Context.
class Context
{
    // A reference to the current state of the Context.
    private State _state = null;

    public Context(State state) => TransitionTo(state);

    // The Context allows changing the State object at runtime.
    public void TransitionTo(State state)
    {
        Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
        _state = state;
        _state.SetContext(this);
    }

    // The Context delegates part of its behavior to the current State
    // object.
    public void Request1() => _state.Handle1();

    public void Request2() => _state.Handle2();
}