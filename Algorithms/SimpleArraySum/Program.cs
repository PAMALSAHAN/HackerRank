using System;
using System.IO;

namespace SimpleArraySum
{
    class Program
    {
        static int simpleArraySum(int[] ar) {
        /*
         * Write your code here.
         */
            int sum=0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum=sum+ar[i];
            }
            return sum;
        

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            
            int result = simpleArraySum(ar);
            System.Console.WriteLine(result);

            // textWriter.WriteLine(result);

            // textWriter.Flush();
            // textWriter.Close();
        }
    
    }
}
