//Rachel McNew
using System;

namespace DEl_2_Iteritive_Statement
{
    class Program

    {
        static void Main(string[] args)
        {//User chooses an integer between 1-100
            Console.WriteLine("please choose a value between 1- 100");

            try 
            {
                string input = Console.ReadLine();

                int input_value = int.Parse(input);
                //establishing counting by 1
                if ((input_value >= 1) && (input_value <= 100))
                {
                    Console.WriteLine("Executing");

                    int count = 1;
                    while (count <= input_value)
                    {
                        Console.WriteLine("You have entered" + input_value + "this is the current int in the loop" + " " + count);
                        count = count + 1;
                    }
                }  //If the user enters a negative number
                else if (input_value < 1)
                { 
                    Console.WriteLine("Enter a number within range");
                }
                  //If the user enters a number larger than 100
                else if (input_value > 100)
                {
                    Console.WriteLine("Enter value in range");
                }

            }
                //If the user enters a invalid integer
            catch
            {
                Console.WriteLine("Enter a value that meets the requirements");
            }
        }
    }
}
