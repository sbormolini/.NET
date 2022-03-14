using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism;

public static class OcrNumbers
{
    private static int HasSegment(char a, char b) => a == b ? 1 : 0;
    private static int Accumulate(int r, int x) => (r << 1) | x;
    private static char ToChar(this int x) => Ocr.ContainsKey(x) ? Ocr[x] : '?';

    private static Dictionary<int, char> Ocr = new()
    {
        [0xAF] = '0',
        [0x09] = '1',
        [0x9E] = '2',
        [0x9B] = '3',
        [0x39] = '4',
        [0xB3] = '5',
        [0xB7] = '6',
        [0x89] = '7',
        [0xBF] = '8',
        [0xBB] = '9',
    };

    public static Queue<T> ToQueue<T>(this IEnumerable<T> a) => new(a);

    private static IEnumerable<T> Pop<T>(Queue<T> q, int count) => 
        Enumerable.Range(0, count).Select(_ => q.Dequeue()).ToArray();

    private static IEnumerable<Queue<char>> GetLetters(this string input)
    {
        var lines = input.Split('\n').Select(ToQueue).ToQueue();
        while (lines.Count > 3)
        {
            var lineSet = Pop(lines, 4).ToArray();
            while (lineSet.All(ls => ls.Count > 2))
            {
                yield return lineSet.SelectMany(line => Pop(line, 3)).ToQueue();
            }
            if (lineSet.Any(ls => ls.Count != 0))
            {
                throw new ArgumentException("incomplete sequence");
            }
            if (lines.Count > 3)
            {
                yield return new Queue<char>();
            }
        }
        if (lines.Count() != 0)
        {
            throw new ArgumentException("incomplete sequence");
        }
    }

    private static char Convert(IEnumerable<char> letter) =>
        letter.Any() ? letter.Zip("*_*|_||_|", HasSegment).Aggregate(0, Accumulate).ToChar() : ',';

    public static string Convert(string input) => 
        new(input.GetLetters().Select(Convert).ToArray());
}