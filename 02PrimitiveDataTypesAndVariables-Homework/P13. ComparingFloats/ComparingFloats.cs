using System;

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Please enter first number.");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number.");
        double second = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        double result = Math.Abs(first - second);

        Console.WriteLine(result<eps);
    }
}
