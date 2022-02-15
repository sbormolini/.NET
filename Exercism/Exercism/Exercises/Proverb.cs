using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        List<string> result = new();

        if (subjects.Length > 1)
        {
            for (int i = 0; i < subjects.Length-1; i++)
                result.Add($"For want of a {subjects[i]} the {subjects[i+1]} was lost.");
        }

        if (subjects.Length > 0)
            result.Add($"And all for the want of a {subjects[0]}.");

        return result.ToArray();
    }
}