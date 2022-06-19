namespace EnvironmentVariableDemo;

internal class Program
{
    static void Main(string[] args)
    {
        var environment = Environment.GetEnvironmentVariable("test");
        Console.WriteLine("test var: " + environment);
    }
}