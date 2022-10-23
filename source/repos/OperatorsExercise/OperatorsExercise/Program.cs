// See https://aka.ms/new-console-template for more information
int a = 17;
int b = 4;

int sum = a + b;
Console.WriteLine($" a + b ={sum}");

int diff = a + b;
Console.WriteLine($" a - b = {diff}");

int product = a + b;
Console.WriteLine($" a * b = {product}");

int quotient = a / b;
Console.WriteLine($" a / b = {quotient}");

int remainder = a % b;
Console.WriteLine($" the remainder is {remainder}");

Console.WriteLine($"a / b is {quotient} remainder {remainder}");
Console.WriteLine();


Console.WriteLine($"What is the radius of your circle");
var radius = double.Parse(Console.ReadLine());

var circle = Math.PI * Math.Pow(radius, 2);

Console.WriteLine($" the area of the circle is {circle}"); 
 


