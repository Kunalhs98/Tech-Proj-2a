using System;

namespace Tech_Proj_2a
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for input
            Console.Write("Enter and Integer value between 1 and 25 to execute an iterative statement: ");

            //Catch block to validate user input

            try
            {
                string input = Console.ReadLine();

                int value_of_input = int.Parse(input);

                if ((value_of_input > 0 ) && (value_of_input <=25))

                {
                    Console.WriteLine("Executing a For Loop!");
                    Console.WriteLine("The For Loop will iterate " + value_of_input.ToString() + " times. ");

                    //For loop
                    
                    for (int i = 1; i <= value_of_input; i++)
                    {
                        Console.WriteLine("You have entered " + value_of_input.ToString() +".This is the current integer value in the loop:" + i.ToString());
                    }
 
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            }
        }
    }
}
