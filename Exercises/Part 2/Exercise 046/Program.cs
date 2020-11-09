using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

    Console.WriteLine("Give a number: ");

    int input1 = Convert.ToInt32(Console.ReadLine());

    int loopCount = 100;

    while (loopCount >= input1)
    {
        Console.WriteLine(input1);
        input1 = (input1 + 1);
    }

    }
  }
}
