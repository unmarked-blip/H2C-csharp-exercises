using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

    Console.WriteLine("Give a number: ");

    int input1 = Convert.ToInt32(Console.ReadLine());

    int loopCount = 0;

    while (loopCount <= input1)
    {
        Console.WriteLine(loopCount);
        loopCount = (loopCount + 1);
    }

    

    }
  }
}
