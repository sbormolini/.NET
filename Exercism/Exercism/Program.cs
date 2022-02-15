// See https://aka.ms/new-console-template for more information
using Exercism;
using Xunit;

var matrix = new[,]
{
        { 9, 8, 7 },
        { 5, 3, 2 },
        { 6, 6, 7 }
};
var actual = SaddlePoints.Calculate(matrix);
var expected = new[] { (2, 1) };

if (expected == actual)
    Console.WriteLine("YES");