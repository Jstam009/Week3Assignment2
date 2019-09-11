using System;

namespace Week3Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How many years experience do you have in professional programming?");

                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);

                if (value_of_input >= 0)
                {
                    for (int i = 0; i <= value_of_input; i++)
                    {
                        Console.WriteLine("You have " + i.ToString() + " years of experience.");
                    }
                }
            }
            catch
            {
                Console.WriteLine("You didnt enter any years!");
            }
        }
    }
}
