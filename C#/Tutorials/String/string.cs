/*
    Funfact: C# was originally going to be called “Cool”—as in C-like Object 
    Oriented Language—but Microsoft changed the name because it sounded more 
    like a marketing slogan than a serious programming language. 😄
*/


// This is a string variable
string aFriend = "Bill";
Console.WriteLine(aFriend);

// Changing the value of the string variable
aFriend = "Maira";
Console.WriteLine(aFriend);

// This is string concatenation
Console.WriteLine("Hello " + aFriend);

//This is string interpolation
Console.WriteLine($"Hello {aFriend}");

// More examples of string interpolation
string firstName = "Gaurav ";
string lastName = "Suman";

// Using interpolation to print first name and last name
Console.WriteLine($"My first-name is:{firstName} and last-name is: {lastName}");

// Using interpolation to print the length of full name
Console.WriteLine($"My full-name is of {firstName.Length + lastName.Length} length");

// Demonstrating trimming of strings
firstName = "       Gaurav     ";

Console.WriteLine($"Original string: [{firstName}]");
Console.WriteLine($"string length: [{firstName.Length}]");
Console.WriteLine($"string trimStart: [{firstName.TrimStart()}]");
Console.WriteLine($"string trimEnd: [{firstName.TrimEnd()}]");
Console.WriteLine($"string trim: [{firstName.Trim()}]");
Console.WriteLine($"string length after trimming: [{firstName.Trim().Length}]");

// Using some string methods
string temp = $"My full-name is of {firstName.Length + lastName.Length} length";
Console.WriteLine(temp.Contains("full-name"));
Console.WriteLine(temp.Replace("full-name", "fullName"));

// Changing case of string
Console.WriteLine(temp.ToLower());
Console.WriteLine(temp.ToUpper());

// Checking how string starts and ends
Console.WriteLine(temp.EndsWith("name"));
Console.WriteLine(temp.StartsWith("My"));