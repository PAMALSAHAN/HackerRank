using System;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            int arCount=Convert.ToInt32(Console.ReadLine());
            int[] ar=Array.ConvertAll(System.Console.ReadLine().Split(' '),tempArr=>Convert.ToInt32(tempArr));
            int result = birthdayCakeCandles(ar);
            System.Console.WriteLine(result);
        }

        public static int birthdayCakeCandles(int[] ar)
        {
            int mx=ar[0];
            int counter=0;
            for (int i = 0; i < ar.Length; i++)
            {
                if(ar[i]>mx)
                {
                    mx = ar[i];
                }

            }
            for (int y = 0; y < ar.Length; y++)
            {
                if(ar[y]==mx){
                    counter++;
                }
            }
            return counter;
        }
    }
}
