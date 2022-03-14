using System.Text;
using System;
using System.Text.RegularExpressions;

namespace Exercism;

public class RotationalCipher
{
    private const string _alphabet = "abcdefghijklmnopqrstuvwxyz";

    public static string Rotate(string text, int shiftKey)
    {
        StringBuilder stringBuilder = new();

        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                int index = _alphabet.IndexOf(char.ToLower(c));
                char newChar = _alphabet[index + shiftKey];
                if (char.IsUpper(c))
                    newChar = char.ToUpper(newChar);

                stringBuilder.Append(newChar);
            }
            else
                stringBuilder.Append(c);

        }
       
        return stringBuilder.ToString();
    }

    public static string RotateTest(string text, int shiftKey)
    {
        return string.Concat(text.Select(c =>
        {
            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                char newChar = (char)(c + shiftKey % 26);
                return (newChar - offset) < 26 ? newChar : (char)(newChar - 26);
            }
            return c;
        }));
    }

}

public class Acronym
{
    public static string Abbreviate(string phrase) => 
        string.Concat(phrase.Where(c => char.IsLetter(c) && char.IsUpper(c)));

    public static string Abbreviate2(string phrase)
    {
        StringBuilder stringBuilder = new();
        var split = phrase.Split(' ');
        foreach (var word in split)
        {
            if (char.IsLetter(word[0]))
                stringBuilder.Append(char.ToUpper(word[0]));
        }

        return stringBuilder.ToString().Trim();
    }

    public static string Abbreviate3(string phrase) => 
        string.Concat(
           Regex.Split(phrase, "[^A-Za-z']+")
                .Select(word => char.ToUpper(word[0])));
    
}

public class Anagram
{
    private readonly string _baseWord;

    public Anagram(string baseWord) => 
        _baseWord = baseWord;

    public bool IsAnagram(string word) => 
        word.ToLower() != _baseWord.ToLower() && string.Concat(_baseWord.ToLower().OrderBy(c => c)) == string.Concat(word.ToLower().OrderBy(c => c));

    public string[] FindAnagrams(string[] potentialMatches) => 
        potentialMatches.Where(word => IsAnagram(word)).ToArray();
}