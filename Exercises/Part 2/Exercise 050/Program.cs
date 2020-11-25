using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
        
    Console.WriteLine("How many times?");

    int input1 = Convert.ToInt32(Console.ReadLine());

    int loopCount = 1;
  
  while (loopCount <= input1)
    {
    PrintPhrase();
    loopCount = (loopCount + 1);
    }

    }
    

    // Write your method here:
    public static void PrintPhrase() 
    {
        Console.WriteLine("In a hole in the ground there lived a method");
    }
  }
}
