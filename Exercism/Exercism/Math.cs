using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism;

public record Movie(string Name, int ReleaseYear, float Rating);

public class Demo
{
    public static void ShowResult(IEnumerable<Movie> result)
    {
        foreach (Movie movie in result)
        {
            Console.WriteLine(movie.Name);
        }
    }
}
