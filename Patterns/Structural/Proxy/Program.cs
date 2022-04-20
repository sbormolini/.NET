// See https://refactoring.guru/design-patterns/proxy/csharp/example#lang-features for more information

using DesignPatterns.Proxy;


Client client = new();

Console.WriteLine("Client: Executing the client code with a real subject:");
RealSubject realSubject = new();
client.ClientCode(realSubject);

Console.WriteLine();

Console.WriteLine("Client: Executing the same client code with a proxy:");
Proxy proxy = new(realSubject);
client.ClientCode(proxy);