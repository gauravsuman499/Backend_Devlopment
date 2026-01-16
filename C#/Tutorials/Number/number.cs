/*     Number   */

using System.Runtime.InteropServices;

// WorkWithIntegers();
// OrderPrecedence();
// WorkWithDoubles();

// Basic Math with integers

void WorkWithIntegers()
{
    int a = 18;
    int b = 6;

    //addition
    int c = a + b;
    Console.WriteLine($"addition: {c}");

    // subtraction
    c = a - b;
    Console.WriteLine($"subtraction: {c}");

    // multiplication
    c = a * b;
    Console.WriteLine($"multiplication: {c}");

    // division
    c = a / b;
    Console.WriteLine($"division: {c}");
}


// Order of Precedence
void OrderPrecedence()
{
    // Order of operations
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    int e = (a+b)*c;
    Console.WriteLine($"check for mathematic operators precedence : {d}");
    Console.WriteLine($"check for mathematic operators precedence : {e}");

    // Integer division
    int x = 7;
    int y = 4;
    int z = 3;
    int res = (x + y) / z;
    Console.WriteLine($"Integer division: {res}");    
}

void QuotientAndRemainder()
{
    // Quotient and Remainder
    // int a = 7;
    // int b = 4;
    // int c = 3;
    // int d = (a + b) / c;
    // int e = (a + b) % c;
    // Console.WriteLine($"quotient: {d}");
    // Console.WriteLine($"remainder: {e}");


    // Type Limits
    // int max = int.MaxValue;
    // int min = int.MinValue;
    // Console.WriteLine($"The range of integers is {min} to {max}");

    // Overflow example
    // int what = max + 3;
    // Console.WriteLine($"An example of overflow: {what}");
    
}


void WorkWithDoubles()
{
    
    // Working with Doubles
    // double a = 5;
    // double b = 4;
    // double c = 2;
    // double d = (a + b) / c;
    // Console.WriteLine(d);


    // More Double Examples
    // double a = 19;
    // double b = 23;
    // double c = 8;
    // double d = (a + b) / c;
    // Console.WriteLine(d);

    // Type Limits for double
    // double max = double.MaxValue;
    // double min = double.MinValue;
    // Console.WriteLine($"The range of double is {min} to {max}");


    // Precision example
    // double third = 1.0 / 3.0;
    // Console.WriteLine(third);
}

void WorkWithDecimals()
{
    // Working with Decimals
    // decimal min = decimal.MinValue;
    // decimal max = decimal.MaxValue;
    // Console.WriteLine($"The range of the decimal type is {min} to {max}");

    // Precision example
    // double a = 1.0;
    // double b = 3.0;
    // Console.WriteLine(a / b);

    // decimal c = 1.0M;
    // decimal d = 3.0M;
    // Console.WriteLine(c / d);
}



//Challenge Question: 
//Q:- write code that calculates the area of a circle whose radius is 2.50 centimeters. 
//    Remember that the area of a circle is the radius squared multiplied by PI

void CalculateCircleArea()
{
    // double radius = 2.50;
    // // double circleArea = Math.PI * (radius * radius); // m-1
    // double circleArea = Math.PI * Math.Pow(radius, 2); // m-2
    // Console.WriteLine($"The area of the circle with radius as {radius} cm is: {circleArea}" );
}

CalculateCircleArea();