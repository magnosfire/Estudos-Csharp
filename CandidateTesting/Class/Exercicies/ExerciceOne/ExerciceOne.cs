using System;

namespace CandidateTesting.RenanRossinideOlivera.AgileExercices.Class
{
    public class ExerciceOne
    {

        public static string DecReprSenior()
        {
            Console.WriteLine("This program will get the largest number between the typed number's siblings.");
            Console.WriteLine("To leave the application, you will need to type \"quit\", and other commands will not work.\n");

            bool closeTheApp = false;

            do
            {

                string typedNumber = Console.ReadLine();

                if (typedNumber.ToLower() == "quit")
                {
                    closeTheApp = true;
                }
                else
                {

                    long result = Siblings.siblingAnalyse(typedNumber);

                    if (result == -1)
                    {
                        Console.WriteLine("The result was bigger than 100,000,000. So : " + -1 + "\n");
                    }
                    else
                    {
                        if (result == -2)
                        {
                            Console.WriteLine("Something went wrong, please check if you typed just numbers.\n");

                        }
                        else
                        {
                            if (result == -3)
                            {
                                Console.WriteLine("The typed number is bigger than 2147483647, please type a number lower than 2147483647.\n");
                            }
                            else if (result >= 0)
                            {

                                Console.WriteLine("The largest number of these siblings' family is : " + result + "\n");

                            }
                        }
                    }

                    Console.WriteLine("Type a new number or quit to finish the program.");

                }

                

            } while (closeTheApp == false);

            return "quit";
        }

    }
}
