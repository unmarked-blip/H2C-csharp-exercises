using System;

namespace exercise_54
{
  class Program
  {
     public static void Main(String[] args)
    {
        Console.WriteLine("Give the smallest number of the range: ");

        int input1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Give the biggest number of the range: ");

        int input2 = Convert.ToInt32(Console.ReadLine());

        DivisibleByThreeInRange(input1,input2);

    }

    public static void DivisibleByThreeInRange(int input1, int input2) 
    {
                        
        while (input1 <= input2)  
            {   
               if ((input1 % 3) == 0)
                  {
                    Console.WriteLine(input1);
                  }
               input1++;
            }
    
        
    
    }
                
            

            
            
  }

}

