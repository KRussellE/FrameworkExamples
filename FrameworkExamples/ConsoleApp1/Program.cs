using FrameworkExamples.Net8;

Console.WriteLine("What is your first name?");
string? firstname = Console.ReadLine();

Console.WriteLine("What is your last name?");
string? lastName  = Console.ReadLine();

string fullName = PersonProcessor.JoinName(firstname, lastName);
Console.WriteLine($"Your fullname is {fullName}");