using System;

namespace PyramidPrints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int length;
            length=Convert.ToInt32(Console.ReadLine()) ;
            
            for (int x = 0; x < length; x++)
            {
                for (int i = 0; i <= x; i++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }

            for (int x = length; x > 0; x--)
            {
                for (int i = x; i > 1; i--)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
                
            }
             
            
        }
    }
}
