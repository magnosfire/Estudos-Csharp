using CandidateTesting.RenanRossinideOlivera.AgileExercices.Class;
using System;

namespace CandidateTesting.RenanRossinideOlivera.AgileExercices
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Type 1 to run the DecReprSenior program");
            Console.WriteLine("Type 2 to run the New CDN iTaas program");

            string choice = "0";

            do
            {
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    choice = ExerciceOne.DecReprSenior();
                }
                else if (choice == "2")
                {
                    choice = ExerciceTwo.Itass();
                }
                else if(choice != "quit" && choice != "1" && choice != "2")
                {
                    Console.WriteLine("Please type 1 to open DecReprSenior, 2 to open New CDN iTaas, or quit to close the application\n");
                }

            } while (choice != "quit");

        }

    }

}
