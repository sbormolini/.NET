// See https://aka.ms/new-console-template for more information

using ReadOnlyListDemo;

Person peter = new("Peter");
Person john = new("John");

peter.AddChild(john);

//// access list without read only list
//IList<Person>? petersChildren = peter.Children as IList<Person>;
//if (petersChildren != null)
//    petersChildren.Add(new Person("Child X"));

peter.PrintChildren();