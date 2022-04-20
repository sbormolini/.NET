namespace DesignPatterns.Visitor;

// The Component interface declares an `accept` method that should take the
// base visitor interface as an argument.

// Each Concrete Component must implement the `Accept` method in such a way
// that it calls the visitor's method corresponding to the component's
// class.
public class ConcreteComponentA : IComponent
{
    // Note that we're calling `VisitConcreteComponentA`, which matches the
    // current class name. This way we let the visitor know the class of the
    // component it works with.
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteComponentA(this);
    }

    // Concrete Components may have special methods that don't exist in
    // their base class or interface. The Visitor is still able to use these
    // methods since it's aware of the component's concrete class.
    public string ExclusiveMethodOfConcreteComponentA()
    {
        return "A";
    }
}
