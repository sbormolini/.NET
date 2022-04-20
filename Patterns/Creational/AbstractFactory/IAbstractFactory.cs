namespace DesignPatterns.AbstractFactory;

public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();

    IAbstractProductB CreateProductB();
}