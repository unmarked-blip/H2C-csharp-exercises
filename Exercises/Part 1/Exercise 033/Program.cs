using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {

    Console.Write("Give the first string: ");

    string firstWord = Console.ReadLine();

    Console.Write("Give the second string: ");

    string secondWord = Console.ReadLine();

        if (string.Compare(firstWord, secondWord) == 0) 
{
        Console.WriteLine("Echo!");
}
        else
{
        Console.WriteLine("Nope!");
}

    }
  }
}
