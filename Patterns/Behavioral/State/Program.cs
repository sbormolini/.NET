// See https://refactoring.guru/design-patterns/state/csharp/example#lang-features for more information

using DesignPatterns.State;

// The client code.
var context = new Context(new ConcreteStateA());
context.Request1();
context.Request2();