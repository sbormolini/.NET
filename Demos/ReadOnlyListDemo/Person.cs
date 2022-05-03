using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyListDemo;

internal class Person
{
    private readonly List<Person> _children;

    public string Name { get; set; }
    //public IEnumerable<Person> Children { get => _children; }
    public IReadOnlyCollection<Person> Children { get => _children.AsReadOnly(); }

    public Person(string name)
    {
        Name = name;
        _children = new List<Person>();
    }

    public void AddChild(Person child)
    {
        Console.WriteLine($"Congratulations! {Name} became a parent for {child.Name}");
        _children.Add(child);
    }

    public void PrintChildren()
    {
        if (_children.Count > 0) 
            Console.WriteLine($"{Name}'s children: ");

        foreach (var child in _children)
        {
            Console.WriteLine(child.Name);
            child.PrintChildren();
        }
    }
}
