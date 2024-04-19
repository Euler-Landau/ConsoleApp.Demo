//Declare variables
using System.Xml;
using System.Xml.Linq;

string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;

Console.WriteLine("Please inter your first name!");
firstName = Console.ReadLine();
Console.WriteLine("Please inter your last name!");
lastName = Console.ReadLine(); 
Console.WriteLine("Please inter your age!");
age = Convert.ToInt32(Console.ReadLine());

// Process the data
int workingYearsRemaining = retirementAge - age;

// OutputMethod the results to the user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");
