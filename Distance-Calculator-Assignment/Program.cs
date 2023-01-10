// Distance Calculator Assignment by Gabriel N.
#nullable disable

// WELCOME
Console.Clear();
Console.WriteLine("Welcome to the distance calculator!");

// INPUT
// x1
Console.Write("Enter x1 value: ");
double x1 = Convert.ToDouble(Console.ReadLine());
// y1
Console.Write("Enter y1 value: ");
double y1 = Convert.ToDouble(Console.ReadLine());
// x2
Console.Write("Enter x2 value: ");
double x2 = Convert.ToDouble(Console.ReadLine());
// y2
Console.Write("Enter y2 value: ");
double y2 = Convert.ToDouble(Console.ReadLine());

// PROCESS
double distance = Math.Sqrt( Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

// OUTPUT
Console.WriteLine($"The distance between the two points is: {distance}");