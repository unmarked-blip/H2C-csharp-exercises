using System;

namespace exercise_32
{
  class Program
  {
    public static void Main(string[] args)
    {

    Console.Write("Speak, friend, and enter: ");

    string friend = Console.ReadLine();

    string friend2 = "Mellon";

        if (string.Compare(friend, friend2) == 0) 
{
        Console.WriteLine("Welcome, friend.");
}
        else
{
        Console.WriteLine("They've got a cave troll!");
}

    }
  }
}
