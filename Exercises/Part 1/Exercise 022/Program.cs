using System;

namespace exercise_22
{
  class Program
  {
    public static void Main(string[] args)
    {

    Console.Write("Give first number: ");

    string firstNumber = Console.ReadLine();

    int firstValue = Convert.ToInt32(firstNumber); 

    Console.Write("Give second number: ");

    string secondNumber = Console.ReadLine();

    int secondValue = Convert.ToInt32(secondNumber);

    Console.Write("Give third number: ");

    string thirdNumber = Console.ReadLine();

    int thirdValue = Convert.ToInt32(thirdNumber);
     
    double average = (firstValue + secondValue + thirdValue) / 3.0 ;

    Console.WriteLine("The average for the numbers is " + average);

    }
  }
}
