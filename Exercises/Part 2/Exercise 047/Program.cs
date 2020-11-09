using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

    Console.WriteLine("Where to: ");

    int input1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Where from: ");

    int loopCount = Convert.ToInt32(Console.ReadLine());

    while (loopCount <= input1)
    {
        Console.WriteLine(loopCount);
        loopCount = (loopCount + 1);
    }
      
    }
  }
}
