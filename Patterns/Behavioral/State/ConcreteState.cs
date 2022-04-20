using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State;

// Concrete States implement various behaviors, associated with a state of
// the Context.
class ConcreteStateA : State
{
    public override void Handle1()
    {
        Console.WriteLine("ConcreteStateA handles request1.");
        Console.WriteLine("ConcreteStateA wants to change the state of the context.");
        _context.TransitionTo(new ConcreteStateB());
    }

    public override void Handle2()
    {
        Console.WriteLine("ConcreteStateA handles request2.");
    }
}

class ConcreteStateB : State
{
    public override void Handle1()
    {
        Console.Write("ConcreteStateB handles request1.");
    }

    public override void Handle2()
    {
        Console.WriteLine("ConcreteStateB handles request2.");
        Console.WriteLine("ConcreteStateB wants to change the state of the context.");
        _context.TransitionTo(new ConcreteStateA());
    }
}