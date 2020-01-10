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
                foreach (string element in args)
                {

                    Console.WriteLine("Hello " + element + "!");

                }

            }
        }
    }
}
