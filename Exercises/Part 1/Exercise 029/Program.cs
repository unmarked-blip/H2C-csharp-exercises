using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {

     Console.Write("Give the first number: ");

    string firstNumber = Console.ReadLine();

    int firstValue = Convert.ToInt32(firstNumber);

    Console.Write("Give the second number: ");

    string secondNumber = Console.ReadLine();

    int secondValue = Convert.ToInt32(secondNumber);

        if (firstValue == secondValue) 
{
        Console.WriteLine("They are equal!");
}

        else if (firstValue > secondValue)
{
        Console.WriteLine("The larger number is " + firstValue);
}


        else
{
        Console.WriteLine("The larger number is " + secondValue);
}

    }
  }
}
