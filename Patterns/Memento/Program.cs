// See https://refactoring.guru/design-patterns/memento/csharp/example#lang-features for more information

using DesignPatterns.Memento;

// Client code.
Originator originator = new("Super-duper-super-puper-super.");
Caretaker caretaker = new(originator);

caretaker.Backup();
originator.DoSomething();

caretaker.Backup();
originator.DoSomething();

caretaker.Backup();
originator.DoSomething();

Console.WriteLine();
caretaker.ShowHistory();

Console.WriteLine("\nClient: Now, let's rollback!\n");
caretaker.Undo();

Console.WriteLine("\n\nClient: Once more!\n");
caretaker.Undo();

Console.WriteLine();