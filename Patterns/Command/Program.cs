// See https://aka.ms/new-console-template for more information

using DesignPatterns.Command;

// The client code can parameterize an invoker with any commands.
Invoker invoker = new();
invoker.SetOnStart(new SimpleCommand("Say Hi!"));
Receiver receiver = new();
invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

invoker.DoSomethingImportant();