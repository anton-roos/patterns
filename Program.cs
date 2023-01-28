var shape = new Shape();
var triangle = new Triangle();
var j = new Journal();

j.AddEntry("Hello World");
j.AddEntry("My name is Tom Riddle");
j.AddEntry("I love adding entries into my journal");
Console.WriteLine(j);

Console.WriteLine(shape);

class Shape
{

}

class Triangle : Shape
{

}