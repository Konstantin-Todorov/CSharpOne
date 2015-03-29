using System;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object strings = hello + " " + world;
            string toObject = (string)strings;
            Console.WriteLine(toObject);
            
        }
    }
}
