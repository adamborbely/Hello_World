using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Hello World!");
            }
            else
            {
                bool first = true;
                foreach (string element in args)
                {
                    if (first)
                    {
                        first = false;
                    }
                    else
                    {
                        Console.WriteLine("Hello " + element + "!");
                    }
                }

            }
        }
    }
}
