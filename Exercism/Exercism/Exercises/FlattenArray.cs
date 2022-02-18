using System.Collections;

namespace Exercism.Exercises;

public class FlattenArray
{
    public static IEnumerable Flatten(IEnumerable input)
    {
        foreach (var i in input)
        {
            if (i is IEnumerable enumerable)
            {
                foreach (var j in Flatten(enumerable))
                    yield return j;
            }
            else if (i is not null)
                yield return i;
        }
    }
}
