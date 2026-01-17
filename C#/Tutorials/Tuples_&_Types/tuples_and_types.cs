/* Tuple */
// Creating and using tuples with named elements
var newTuple = (X: 4, Y:8);
var slope = (double)newTuple.Y / (double)newTuple.X;
Console.WriteLine($"A line from the origin to the point {newTuple} has a slope of {slope}.");

// Modifying tuple elements and creating new tuples with 'with' expression
newTuple.X = newTuple.X + 5;
Console.WriteLine($"The point is now at {newTuple}.");
var duplicateTuple = newTuple with {Y = 20};
Console.WriteLine($"The point 'duplicateTuple' is at {duplicateTuple}.");

// Assigning tuples to other tuples
var subscript = (A: 0, B: 0);
subscript = newTuple;
Console.WriteLine(subscript);

// More tuple examples
var namedData = (Name: "Morning observation", Temp: 17, Wind: 4);
var person = (FirstName: "", LastName: "");
var order = (Product: "guitar picks", style: "triangle", quantity: 500, UnitPrice: 0.10m);



/*Record*/
// Creating and using record structs
Point pt1 = new Point(10, 20);
Console.WriteLine($"The pt1 point is : {pt1}");

// Modifying record struct properties and creating new instances with 'with' expression
Point pt2 = pt1 with {Y = 100};
Console.WriteLine($"The pt2 point is : {pt2}");

// Calling methods defined in the record struct
double slopeResult = pt2.Slope();
Console.WriteLine($"The slope of {pt2} is {slopeResult}");

// More record struct examples
public record struct Point(int X, int Y){
    public double Slope() => (double)Y / (double)X;
}
