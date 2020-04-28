using System;
using System.Collections.Generic;
using System.Collections;
namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = new List<int>();
            result =gradingStudents(grades);

            foreach (int item in result)
            {
                System.Console.WriteLine(item);
            }




        }
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> finalGrade=new List<int>();
            foreach (int item in grades)
            {
                if(item+3<40){
                    finalGrade.Add(item);
                }
                else{

                    if((item+1)%5 == 0){
                        finalGrade.Add(item+1);
                    }
                    else if((item+2)%5 == 0){
                        finalGrade.Add((item+2));
                    }
                    else{
                        finalGrade.Add(item);
                    }

                }
            }
            return finalGrade;
        }
    }
}
