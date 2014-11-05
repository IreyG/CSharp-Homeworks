using System;
using System.Collections.Generic;
using System.Linq;

class HalfSum
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<int> numbers1 = new List<int>();
        List<int> numbers2 = new List<int>();

        for (int i = 0; i < 2*n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (i<n)
            {
		      numbers1.Add(num);  
            }
            else
            {
                numbers2.Add(num);
            }
        }
        if (numbers1.Sum() == numbers2.Sum())
        {
            Console.WriteLine("Yes, sum={0}", numbers1.Sum());
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(numbers1.Sum()-numbers2.Sum()));
        }
    }
}
