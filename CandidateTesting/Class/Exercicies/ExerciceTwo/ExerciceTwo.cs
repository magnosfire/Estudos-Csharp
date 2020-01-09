using System;

namespace CandidateTesting.RenanRossinideOlivera.AgileExercices.Class
{
    public class ExerciceTwo
    {

        public static string Itass()
        {

            Console.WriteLine("This program is used to convert \"MINHA CDN\" logs to the \"AGORA\" log format.");
            Console.WriteLine("Type the action, URL, and the output to store the file.");
            Console.WriteLine("Example: convert http://logstorage.com/minhaCdn1.txt ./output/minhaCdn1.txt");
            Console.WriteLine("To leave the application, you will need to type \"quit\", and other commands will not work. \n");


            string result;

            do
            {
                //Get the user command
                string rawUserCommand = Console.ReadLine();

                result = FileCreation.CommandAnalyse(rawUserCommand);


                if (result == "error")
                {
                    Console.WriteLine("Something went wrong, please check your URL, output and try again.\n");
                }
                else if (result == "success")
                {
                    Console.WriteLine("Your request finished with success! \n");
                }
                else if (result == "error command")
                {
                    Console.WriteLine("Something went wrong. Please verify if the command is typed in the following way : convert URL output");
                }



                Console.WriteLine("Type a new command to convert or quit to finish the program.");

            } while (result.ToLower() != "quit");

            return "quit";


        }

    }
}
