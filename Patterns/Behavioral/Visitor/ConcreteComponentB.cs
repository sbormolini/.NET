namespace DesignPatterns.Visitor;

// The Component interface declares an `accept` method that should take the
// base visitor interface as an argument.

// Each Concrete Component must implement the `Accept` method in such a way
// that it calls the visitor's method corresponding to the component's
// class.
public class ConcreteComponentB : IComponent
{
    // Same here: VisitConcreteComponentB => ConcreteComponentB
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteComponentB(this);
    }

    public string SpecialMethodOfConcreteComponentB()
    {
        return "B";
    }
}
