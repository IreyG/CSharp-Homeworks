using System;
class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        b = a - b; //5 - 10 = -5
        a = a - b; //5 - (-5) = 10
        b = a + b; // (10+(-5)) = 5
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}