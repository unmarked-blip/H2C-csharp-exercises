using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
        Console.WriteLine("Give a number");

        int input1 = Convert.ToInt32(Console.ReadLine());
            
        ChristmasTree(input1);

    }




    public static void PrintStars(int input1)
    {
         for (int number = 0; number<input1; number++)
                {
                    Console.Write("*");
                }
      Console.WriteLine("");
         
    }

    public static void PrintSpaces(int input1)
    {
         for (int number = 0; number<input1; number++)
                {
                    Console.Write(" ");
                }
    }

    public static void PrintRightTriangle(int input1)
    {
        for (int i=1; i<=input1; i++)
			{
                PrintSpaces(input1-i);
                PrintStars(i);
			}
    }

    public static void ChristmasTree(int input1)
    {
        for (int i=0; i<=input1; i++)
                {
                  PrintSpaces(input1-i);
                  PrintStars((i*2)-1);
                  
                }
        
        int lastRow = ((input1*2)-3)/2;

        for (int i = 0; i < 2; i++)
            {
                PrintSpaces(lastRow);
                PrintStars(3);

            }   
        
    }
  }
}
