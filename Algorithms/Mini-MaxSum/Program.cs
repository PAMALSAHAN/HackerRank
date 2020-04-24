using System;

namespace Mini_MaxSum
{
    class Program
    {
        static void miniMaxSum(long[] arr) {
            
            long mx=arr[0];
            long mn=arr[0];
            
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]>mx)
                {
                    mx = arr[i];
                }


                if(arr[i]<mn)
                {
                    mn = arr[i];
                }
            }
            
            long minSum=0;
            long maxSum=0;
            int counter=0;

            for (int x = 0; x < arr.Length; x++)
            {
                if(arr[x]==mx && counter==0 ){
                    counter=1;
                    
                    
                }
                else if(arr[x]==mx && counter==1){
                    maxSum=maxSum+arr[x];
                }
                else if(arr[x]!=mx){
                    maxSum=maxSum+arr[x];
                }
                else{
                    maxSum=maxSum+0;
                }
            }
        

            System.Console.Write(maxSum);
            System.Console.Write(" ");

            counter=0;
            for (int y = 0; y < arr.Length; y++)
            {
                if(arr[y]==mn && counter==0 ){
                    counter=1;
                    
                    
                }
                else if(arr[y]==mn && counter==1){
                    minSum=minSum+arr[y];
                }
                else if(arr[y]!=mn){
                    minSum=minSum+arr[y];
                }
                else{
                    minSum=minSum+0;
                }
            }
            System.Console.WriteLine(minSum);

        }

        static void Main(string[] args)
        {
            
            long[] arr=Array.ConvertAll(Console.ReadLine().Split(' '),tempArr=>Convert.ToInt64(tempArr));
        
            miniMaxSum(arr);
        }
    }
}
