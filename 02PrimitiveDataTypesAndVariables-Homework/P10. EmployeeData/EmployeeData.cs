using System;
using System.Numerics;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Rob";
        string lastName = "Halford";
        byte age = 63;
        char gender = 'm';
        long personalID = 5108251234;
        BigInteger uen = BigInteger.Parse("21324650000021654878651322335045656");

        Console.WriteLine("First Name : {0}", firstName);
        Console.WriteLine("Last Name : {0}", lastName);
        Console.WriteLine("Age : {0}", age);
        Console.WriteLine("Gender : {0}", gender);
        Console.WriteLine("Personal ID Number : {0}", personalID);
        Console.WriteLine("Unique Employee Number : {0}", uen);
    }
}
