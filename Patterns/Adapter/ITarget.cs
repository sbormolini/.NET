namespace DesignPatterns.Adapter;

// The Target defines the domain-specific interface used by the client code.
public interface ITarget
{
    string GetRequest();
}
