// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

// Q1
Console.WriteLine("Enter your name: ");
string firstName = Console.ReadLine();
Console.WriteLine("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Hello " + firstName + ", in 5 years you will be " + (age+5));

// Q2
Console.WriteLine("Enter age: ");
int userAge = Convert.ToInt32(Console.ReadLine());
if (userAge <13)
{
    Console.WriteLine("Child");
}
else if (userAge >= 13 && userAge <= 19)
{
    Console.WriteLine("Teenager");
}
else
{
    Console.WriteLine("Adult");
}

// Q3
Console.WriteLine("Enter number:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    Console.WriteLine("Positive");
}
else if (number < 0)
{
    Console.WriteLine("Negative");
}
else
{
    Console.WriteLine("Number is 0");
}

// Q4
Console.WriteLine("Enter year:");
int year = Convert.ToInt32(Console.ReadLine());
if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
{
    Console.WriteLine("Leap year");
}
else if (year < 0)
{
    Console.WriteLine("Year invalid");
}
else
{
    Console.WriteLine("Not a leap year");
}


// Q5
Console.WriteLine("Enter number:");
int evenOdd = Convert.ToInt32(Console.ReadLine());
if (evenOdd % 2 == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}
