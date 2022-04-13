// See https://refactoring.guru/design-patterns/template-method/csharp/example#lang-features for more information

namespace DesignPatterns.TemplateMethod;

class Client
{
    // The client code calls the template method to execute the algorithm.
    // Client code does not have to know the concrete class of an object it
    // works with, as long as it works with objects through the interface of
    // their base class.
    public static void ClientCode(AbstractClass abstractClass)
    {
        // ...
        abstractClass.TemplateMethod();
        // ...
    }
}
