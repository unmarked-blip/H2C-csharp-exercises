using System;

namespace exercise_23
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

    int sum = firstValue + secondValue;

    int deduct = firstValue - secondValue;

    int multiply = firstValue * secondValue;

    double divide = (double)firstValue / (double)secondValue;

    Console.WriteLine((double)firstValue + " + " + secondValue + " = " + sum + "\n" +
        firstValue + " - " + secondValue + " = " + deduct + "\n" +
        firstValue + " * " + secondValue + " = " + multiply + "\n" +
        firstValue + " / " + secondValue + " = " + divide);

    }
  }
}
