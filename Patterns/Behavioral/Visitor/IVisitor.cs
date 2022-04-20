namespace DesignPatterns.Visitor;

public interface IVisitor
{
    void VisitConcreteComponentA(ConcreteComponentA element);

    void VisitConcreteComponentB(ConcreteComponentB element);
}
