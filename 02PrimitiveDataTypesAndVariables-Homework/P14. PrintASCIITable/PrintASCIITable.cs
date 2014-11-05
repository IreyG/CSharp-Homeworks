using System;

class PrintASCIITable
{
    static void Main(string[] args)
    {
        System.Console.OutputEncoding = System.Text.Encoding.Unicode;

        for (int i = 0; i <= 255; i++)
        {
            Console.WriteLine("{0} = {1}", i, (char)i);
        }
    }
}
