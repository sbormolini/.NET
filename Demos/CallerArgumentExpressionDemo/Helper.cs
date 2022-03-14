using System.Runtime.CompilerServices;

namespace CallerArgumentExpressionDemo;

public class Helper
{
    public static void ItIsNotEmpty<T>(
        IEnumerable<T> value,
        [CallerArgumentExpression("value")] string message = "")
    {
        if (!value.Any())
            throw new ArgumentException("Enumerable is empty", message);
    }
}
