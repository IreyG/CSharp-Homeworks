using System;

class Sunglasses
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char frame = '*';
        string frameSpace = new String(frame, n * 2);
        char lens = '/';
        string lensSpace = new String(lens, n * 2 - 2);
        char bridge = '|';
        string bridgeSpace = new String(bridge, n);
        char empty = ' ';
        string emptySpace = new String(empty, n);

        Console.WriteLine("{0}{1}{0}", frameSpace, emptySpace, frameSpace);

        for (int i = 0; i < n - 2; i++)
        {
            if (i == n / 2 - 1)
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", frame, lensSpace, bridgeSpace);
            }
            else
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", frame, lensSpace, emptySpace);
            }
        }
        Console.WriteLine("{0}{1}{0}", frameSpace, emptySpace, frameSpace);
    }
}
