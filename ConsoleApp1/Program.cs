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


/* // 3. Variables
int x; // declaration
x = 123; // initialization

int y = 321; // declaration + initialization (expression)

int z = x + y;

int age = 21; // whole interger
double height = 300.5; // decimal number
bool alive = true; // true or false
char symbol = '@';
string name = "woi";

Console.WriteLine($"Hello {name}");
Console.WriteLine($"Your age is {age}");
Console.WriteLine($"Your height is {height}");
Console.WriteLine($"Are you alive? {alive}");
Console.WriteLine($"Your symbol is {symbol}");

String userName = symbol + name;

Console.WriteLine($"Your username is {userName}");

Console.ReadKey(); */


/* // 4. Constants
// immutable values which are known at compile time and do not change for life of the program

const double pi = 3.14159;

Console.WriteLine(pi);

Console.ReadKey(); */


/* // 5. Type casting
// Converting a value to a different data type. Useful when we accept user input (string). Different data types can do different things.

double a = 3.14;
int b = Convert.ToInt32(a);

int c = 123;
double d = Convert.ToDouble(c);

int e = 321;
String f = Convert.ToString(e); 

String g = "$";
char h = Convert.ToChar(g);

String i = "true";
bool j = Convert.ToBoolean(i);

Console.WriteLine(a.GetType());
Console.WriteLine(d.GetType());
Console.WriteLine(f.GetType());
Console.WriteLine(h.GetType());
Console.WriteLine(j.GetType());

Console.ReadKey(); */


/* // 6. User input

Console.WriteLine("Input your name: ");
string name = Console.ReadLine();

Console.WriteLine("What is your age: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Hello {name}");
Console.WriteLine($"You are {age} old");

Console.ReadKey(); */


/* // 7. Arithmetic operators

int friends = 10;

// friends = friends + 2;
// friends += 2;
// friends++;

// friends = friends - 1;
// friends -= 1;
// friends--;

// friends = friends * 2;
// friends *= 2;

// friends = friends / 2;
// friends /= 2;

int remainder = friends % 3;

Console.WriteLine(remainder);

Console.ReadKey(); */


// 8. Math
/* double x = 3;

double a = Math.Pow(x, );
double a = Math. */

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


/* // a. Even or odd checker
Console.WriteLine("Enter a number:");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

if (number % 2 == 0) {
    Console.WriteLine($"{number} is an even number.");
}
else {
    Console.WriteLine($"{number} is an odd number.");
} */
