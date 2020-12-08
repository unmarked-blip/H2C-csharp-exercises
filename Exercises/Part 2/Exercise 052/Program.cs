using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
     Console.WriteLine("From which number?");

    int input1 = Convert.ToInt32(Console.ReadLine());

    PrintToNumber(input1);  


    }

    public static void PrintToNumber(int input1) 
    {
            int loopCount = 1;
            while (loopCount <= input1)
            {
            Console.WriteLine(input1);

            input1--;
            }
    }
  }
  
}
