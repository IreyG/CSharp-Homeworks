using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine(a);
        Console.WriteLine(b);
        a = 5;
        b = 15.6549798465454D;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}
