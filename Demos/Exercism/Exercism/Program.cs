// See https://aka.ms/new-console-template for more information
using Exercism;

//string value = AtbashCipher.Encode("aez");
//Console.WriteLine(value);

var rows =
            "   \n" +
            "  |\n" +
            "  |\n" +
            "   ";

var actual = OcrNumbers.Convert(rows);
Console.WriteLine($"Number is {actual}");