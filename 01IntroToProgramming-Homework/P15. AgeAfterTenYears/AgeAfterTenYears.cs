using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Please enter your birthday");
        DateTime birthDay = DateTime.Parse(Console.ReadLine());
        int years = DateTime.Now.Year - birthDay.Year;
        Console.WriteLine("You are {0} years old.", years);
        int ageInTen = years + 10;
        Console.WriteLine("In 10 years, you are going to be {0} years old.", ageInTen);


    }
}