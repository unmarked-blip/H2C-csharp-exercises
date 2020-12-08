using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
     Console.WriteLine("To which number?");

    int input1 = Convert.ToInt32(Console.ReadLine());

    PrintUntilNumber(input1);  


    }

   public static void PrintUntilNumber(int input1) 
    {
            int loopCount = 1;
            while (loopCount <= input1)
            {
            Console.WriteLine(loopCount);

            loopCount++;
            }
    }

  }
}
