using System;

namespace exercise_60
{
  class Program
  {
        public static void Main(String[] args)
        {
                
        Console.WriteLine("Give size");

        int input1 = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Give height");

        // int width = Convert.ToInt32(Console.ReadLine());
     
        // PrintRectangle(input1, height);

        PrintTriangle(input1);
        
        }
    
        
  

    


    public static void PrintStars(int input1)
    {
      // you can print one star with the command
      
         for (int number = 0; number<input1; number++)
                {
                    Console.Write("*");
                }
      // call the print command n times
      // in the end print a line break with the comand
      Console.WriteLine("");
    }

    public static void PrintSquare(int input1)
    {
        for (int number = 0; number<input1; number++)
                {
                    PrintStars(input1);
                }
        Console.WriteLine("");
    }

    public static void PrintRectangle(int input1, int height)
    {
      for (int number = 0; number<height; number++)
                {
                    PrintStars(input1);
                }
        Console.WriteLine("");
    }

    public static void PrintTriangle(int input1)
    {
        int number = 1;
        while (number <= input1)
                {
                    PrintStars(number);
                    number++;
                }

    }
  }
}


