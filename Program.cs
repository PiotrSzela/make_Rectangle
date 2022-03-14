using System;

namespace make_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the lenght: ");
            string xs = Console.ReadLine();
            Console.Write("Enter the height: ");
            string ys = Console.ReadLine();
            int x = int.Parse(xs);
            int y = int.Parse(ys);
            Console.WriteLine();

            for (int i = 0; i < y; i++)
            {
                Console.WriteLine(" ");

                    for (int j = 0; j < x; j++)
                    {
                    
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" *");

                    }
                
                Console.WriteLine();

            }
            Console.ResetColor();
            Console.ReadKey();

        }
    }
}
