using System;

class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object concat = " ";
        string helloworld = hello + concat + world;
        Console.WriteLine(helloworld);
    }
}
