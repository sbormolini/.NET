﻿// See https://refactoring.guru/design-patterns/chain-of-responsibility/csharp/example#lang-features for more information

using DesignPatterns.ChainOfResponsibility;


// The other part of the client code constructs the actual chain.
var monkey = new MonkeyHandler();
var squirrel = new SquirrelHandler();
var dog = new DogHandler();

monkey.SetNext(squirrel).SetNext(dog);

// The client should be able to send a request to any handler, not
// just the first one in the chain.
Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
Client.ClientCode(monkey);
Console.WriteLine();

Console.WriteLine("Subchain: Squirrel > Dog\n");
Client.ClientCode(squirrel);