// See https://refactoring.guru/design-patterns/adapter/csharp/example#lang-features for more information

using DesignPatterns.Adapter;

Adaptee adaptee = new Adaptee();
ITarget target = new Adapter(adaptee);

Console.WriteLine("Adaptee interface is incompatible with the client.");
Console.WriteLine("But with adapter client can call it's method.");

Console.WriteLine(target.GetRequest());
