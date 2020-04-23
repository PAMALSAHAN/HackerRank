using System;

namespace URLExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
         //   Console.WriteLine("Hello World!");

            string phrase = Console.ReadLine();
            
            string[] words = phrase.Split('?');

            // foreach (var word in words)
            // {
            //     System.Console.WriteLine($"<{word}>");
            // }
            string key=words[1];
           // System.Console.WriteLine(key);
             string[] kv = key.Split('&');

            //    foreach (var wordkv in kv)
            // {
            //     System.Console.WriteLine($"<{wordkv}>");
            //     string[] kvu = kv[1].Split('=');
            // }

            for (int i = 0; i < kv.Length; i++)
            {
                string[] kvu = kv[i].Split('=');
                 System.Console.WriteLine($"{kvu[0]} {kvu[1]}");
            }

           
        }
    }
}
