using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory;

// Concrete Products are created by corresponding Concrete Factories.
class ConcreteProductB1 : IAbstractProductB
{
    public string UsefulFunctionB()
    {
        return "The result of the product B1.";
    }

    // The variant, Product B1, is only able to work correctly with the
    // variant, Product A1. Nevertheless, it accepts any instance of
    // AbstractProductA as an argument.
    public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
    {
        var result = collaborator.UsefulFunctionA();

        return $"The result of the B1 collaborating with the ({result})";
    }
}

class ConcreteProductB2 : IAbstractProductB
{
    public string UsefulFunctionB()
    {
        return "The result of the product B2.";
    }

    // The variant, Product B2, is only able to work correctly with the
    // variant, Product A2. Nevertheless, it accepts any instance of
    // AbstractProductA as an argument.
    public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
    {
        var result = collaborator.UsefulFunctionA();

        return $"The result of the B2 collaborating with the ({result})";
    }
}