// See https://refactoring.guru/design-patterns/iterator/csharp/example#lang-features for more information

using DesignPatterns.Iterator;

// The client code may or may not know about the Concrete Iterator
// or Collection classes, depending on the level of indirection you
// want to keep in your program.
var collection = new WordsCollection();
collection.AddItem("First");
collection.AddItem("Second");
collection.AddItem("Third");

Console.WriteLine("Straight traversal:");

foreach (var element in collection)
{
    Console.WriteLine(element);
}

Console.WriteLine("\nReverse traversal:");

collection.ReverseDirection();

foreach (var element in collection)
{
    Console.WriteLine(element);
}