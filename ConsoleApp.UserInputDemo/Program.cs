//Declare variables
using System.Xml;

string name = string.Empty;
int age = 0;
int retirementAge = 65;

Console.WriteLine("Please inter your name!");
name = Console.ReadLine();
Console.WriteLine("Please inter your age!");
age = Convert.ToInt32(Console.ReadLine());

// Process the data
int workingYearsRemaining = retirementAge - age;

// OutputMethod the results to the user
Console.WriteLine($"Full name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");
