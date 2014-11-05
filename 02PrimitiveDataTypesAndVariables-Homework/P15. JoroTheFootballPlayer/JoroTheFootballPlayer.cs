using System;

class JoroTheFootballPlayer
{
    static void Main(string[] args)
    {
        string leap = Console.ReadLine(); ; //leap
        int p = int.Parse(Console.ReadLine()); //holidays
        int h = int.Parse(Console.ReadLine()); //hometown

        double weeks = 52;
        double playsFootball;

        if (leap == "t")
        {
            playsFootball = 3 + (p/2) + h + ((weeks - h) / 3) * 2;
        }
        else
        {
            playsFootball = p/2 + h + ((weeks - h) / 3) * 2;
        }
        Console.WriteLine((int)playsFootball);
    }
}
