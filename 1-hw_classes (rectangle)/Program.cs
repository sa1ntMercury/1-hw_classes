using _1_hw_classes__rectangle_;

Console.WriteLine("Input first side lenght:");
double side1 = double.Parse(Console.ReadLine());
Console.WriteLine("Input second side lenght:");
double side2 = double.Parse(Console.ReadLine());

Rectangle rectangle = new Rectangle(side1, side2);

Console.WriteLine($"Area = {rectangle.Area};\tPerimeter = {rectangle.Perimeter}");