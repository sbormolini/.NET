// See https://refactoring.guru/design-patterns/prototype/csharp/example#lang-features for more information

using DesignPatterns.Prototype;

Person p1 = new();
p1.Age = 42;
p1.BirthDate = Convert.ToDateTime("1977-01-01");
p1.Name = "Jack Daniels";
p1.IdInfo = new IdInfo(666);

// Perform a shallow copy of p1 and assign it to p2.
Person p2 = p1.ShallowCopy();
// Make a deep copy of p1 and assign it to p3.
Person p3 = p1.DeepCopy();