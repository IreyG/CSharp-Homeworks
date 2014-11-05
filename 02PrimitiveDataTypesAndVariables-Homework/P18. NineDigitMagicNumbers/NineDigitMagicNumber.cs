using System;
using System.Collections.Generic;
using System.Linq;

class NineDigitMagicNumber
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int number1;
        int number2;
        int number3;
        int result = 0;

        for (int i = 111; i <= 777; i++)
        {
            number1 = i;
            number2 = i + diff;
            number3 = number2 + diff;

            List<int> number = new List<int>();
            number.Add((number1 / 100) % 10);
            number.Add((number1 / 10) % 10);
            number.Add(number1 % 10);
            number.Add((number2 / 100) % 10);
            number.Add((number2 / 10) % 10);
            number.Add(number2 % 10);
            number.Add((number3 / 100) % 10);
            number.Add((number3 / 10) % 10);
            number.Add(number3 % 10);

            if (!number.Contains(9) && !number.Contains(8) && !number.Contains(0))
            {
                if (number[0] + number[1] + number[2] + number[3] + number[4] + number[5] + number[6] + number[7] + number[8] == sum)
                {
                    Console.WriteLine("{0}{1}{2} ", number1, number2, number3);
                    result++;
                }
            }
        }
        if (result == 0)
        {
            Console.WriteLine("No");
        }
    }
}