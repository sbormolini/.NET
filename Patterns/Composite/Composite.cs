// See https://refactoring.guru/design-patterns/composite/csharp/example#lang-features for more information

namespace DesignPatterns.Composite;

// The Composite class represents the complex components that may have
// children. Usually, the Composite objects delegate the actual work to
// their children and then "sum-up" the result.
class Composite : Component
{
    protected List<Component> _children = new();

    public override void Add(Component component) => _children.Add(component);

    public override void Remove(Component component) => _children.Remove(component);

    // The Composite executes its primary logic in a particular way. It
    // traverses recursively through all its children, collecting and
    // summing their results. Since the composite's children pass these
    // calls to their children and so forth, the whole object tree is
    // traversed as a result.
    public override string Operation()
    {
        int i = 0;
        string result = "Branch(";

        foreach (Component component in this._children)
        {
            result += component.Operation();
            if (i != this._children.Count - 1)
            {
                result += "+";
            }
            i++;
        }

        return result + ")";
    }
}