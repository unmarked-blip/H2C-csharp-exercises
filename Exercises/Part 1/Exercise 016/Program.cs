using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

    Console.WriteLine("How many days? ");

    string days = Console.ReadLine();

    int dayValue = Convert.ToInt32(days);            

    Console.WriteLine("That is " + dayValue * 86400 + " seconds." );

    }
  }
}
