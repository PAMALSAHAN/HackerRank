using System;

namespace SaveHumanityAgainstCOVID_19
{
    class Program
    {
        static void Main(string[] args)
        {
            string s =Console.ReadLine();
            
           string[] starr=s.Split(' ');

           int[] myInts = Array.ConvertAll(starr, int.Parse);

          
        
            int even = 0, odd = 0; 
    
            // Loop to find even, odd sum 
            for (int i = 0; i < myInts.Length; i++) 
            { 
                if (i % 2 == 0) 
                    even += myInts[i]; 
                else
                    odd += myInts[i]; 
            } 

            if (even>odd)
            {
                System.Console.WriteLine(even);
            }else{
                System.Console.WriteLine(odd);
            }
    
       
        }

    }
}
