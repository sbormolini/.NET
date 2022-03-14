using System.Text.RegularExpressions;

namespace Exercism.Exercises;

public static class IsbnVerifier
{
    private const string IsbnPattern = @"^\d(-?)\d{3}\1\d{5}\1[\dX]$";

    public static bool IsValid(string number) => 
        IsIsbnPattern(number) && IsValidIsbnCheckSum(number);

    private static bool IsIsbnPattern(string number) => 
        Regex.IsMatch(number, IsbnPattern);

    private static bool IsValidIsbnCheckSum(string number) => 
        GetIsbnCheckSum(number) % 11 == 0;
   
    private static int GetIsbnCheckSum(string number) => 
        IsbnDigits(number).Select((x, i) => x * (10 - i)).Sum();

    private static IEnumerable<int> IsbnDigits(string number) => 
        number.Where(char.IsLetterOrDigit).Select(x => x == 'X' ? 10 : int.Parse(x.ToString()));
}