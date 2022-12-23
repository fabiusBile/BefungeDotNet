// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using BefungeDotNet.Core;

var program =
    """"
    "!dlroW ,olleH">:v
                   |,<
                   @
    """";

var cts = new CancellationTokenSource();

Console.CancelKeyPress += (s, e) =>
{
    Console.WriteLine("Canceling...");
    cts.Cancel();
    e.Cancel = true;
};

var interpreter = new Interpreter(program);
await interpreter.StartAsync(cts.Token);