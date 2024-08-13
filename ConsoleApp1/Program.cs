// See https://aka.ms/new-console-template for more information


// 1. datetime with Indonesian format
/* using System.Globalization;

DateTime now = DateTime.Now;
CultureInfo indonesianCulture = new CultureInfo("en-ID");
string formattedDate = now.ToString("dd MMMM yyyy", indonesianCulture);

Console.WriteLine("Aozora o matteru");
Console.WriteLine(formattedDate); */


// 2. Convert / Type Casting
/* int e = 25;
String f = Convert.ToString(e);
// String g = Convert.ToDouble(e);

Console.WriteLine(e.GetType()); */


// 3. User input
/* Console.WriteLine("Enter your name");
String name = Console.ReadLine();

Console.WriteLine("Enter your age?");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your name is {name} and your age is {age}");

Console.ReadKey(); */

// 4. arithmeticf

int a = 5;

// a += 5;
a *= 2;

Console.WriteLine(a);
