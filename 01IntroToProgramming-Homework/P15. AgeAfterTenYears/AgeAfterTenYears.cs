using System;

class AgeAfterTenYears
{
    static void Main()
    {
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;
        int age = today.Year - birthday.Year;
        if (today.Month-birthday.Month<0)
        {
            age--;
        }
        if (today.Month==birthday.Month && today.Day-birthday.Day<0)
        {
            age--;
        }
        int ageInTen = age + 10;
        Console.WriteLine("You are {0} years old.",age);
        Console.WriteLine("In 10 years from today you will be {0} years old.",ageInTen);
    }
}
