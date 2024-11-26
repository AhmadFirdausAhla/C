// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your name");
var name = Console.ReadLine();
Console.WriteLine("How old are you");
var old = Console.ReadLine();
Console.WriteLine("What is your dream");
var dream = Console.ReadLine();
Console.Write($"{Environment.NewLine} Hello {name}, you are {old} and i wish you got your dream as {dream}!!");
Console.Write($"{Environment.NewLine}Press any button to exit");
Console.ReadKey(true);