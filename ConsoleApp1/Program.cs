// See https://aka.ms/new-console-template for more information


/* // 1. C# tutorial for beginners
Console.WriteLine("I like pizza!");
Console.WriteLine("It's really good");
// Console.Beep(); */


/* // 2. Output
Console.Write("Hey!");
Console.WriteLine("Hello!");

// This is a comment

Console.WriteLine("Hello\nWorld");

Console.ReadKey(); */


// 3. Variables
int x; // declaration
x = 123; // initialization

int y = 321; // declaration + initialization (expression)

int z = x + y;

int age = 21; // whole interger
double height = 300.5; // decimal number
bool alive = true;

Console.WriteLine($"Your age is {age}");
Console.WriteLine($"Your height is {height}");
Console.WriteLine($"Are you alive? {alive}");

Console.ReadKey();

/* // 1. datetime with Indonesian format
using System.Globalization;

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

/* int a = 5;

// a += 5;
a *= 2;

Console.WriteLine(a); */

/* Console.WriteLine("Enter side A: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter side B: ");
double b = Convert.ToDouble(Console.ReadLine());

double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

string result = $"The hypotenuse is {c}";

Console.WriteLine(result);

Console.ReadKey(); */
