// See https://refactoring.guru/design-patterns/observer/csharp/example#lang-features for more information

using DesignPatterns.Observer;

// The client code.
var subject = new Subject();
var observerA = new ConcreteObserverA();
subject.Attach(observerA);

var observerB = new ConcreteObserverB();
subject.Attach(observerB);

subject.SomeBusinessLogic();
subject.SomeBusinessLogic();

subject.Detach(observerB);

subject.SomeBusinessLogic();