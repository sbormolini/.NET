using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism;

public class Robot
{
    private static readonly Random _random = new();
    private static readonly string _letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private static readonly string _digits = "0123456789";

    private static readonly HashSet<string> _usedNames = new();

    public string? Name { get; private set; }


    public Robot() => SetRobotName();

    public void Reset() => SetRobotName();

    // helper
    private void SetRobotName() => Name = NewUniqueName();

    private static string RandomString(string charactersToUse, int numberOfCharacters) =>
        new(Enumerable.Repeat(charactersToUse, numberOfCharacters)
        .Select(s => s[_random.Next(s.Length)])
        .ToArray());

    private static bool IsNameUnique(string name) => _usedNames.Add(name);

    private string NewUniqueName()
    {
        string newName = NewName();
        return (IsNameUnique(newName)) ? newName : NewUniqueName();
    }

    private static string NewName() => RandomString(_letters, 2) + RandomString(_digits, 3);
}
