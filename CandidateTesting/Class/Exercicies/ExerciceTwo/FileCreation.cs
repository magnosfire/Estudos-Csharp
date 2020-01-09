using System;
using System.Net;
using System.IO;



namespace CandidateTesting.RenanRossinideOlivera.AgileExercices.Class
{
    public class FileCreation
    {


        public static string[] splitString(string stringToSplit, string splitString)
        {

            string[] returnArray = stringToSplit.Split(splitString);
            return returnArray;

        }

        public static string CommandAnalyse(string rawUserCommand)
        {

            //Split the command to get the action, URL and output
            //userCommand[0] action
            //userCommand[1] URL
            //userCommand[2] Output
            string[] userCommand = FileCreation.splitString(rawUserCommand, " ");


            if (userCommand[0].ToLower() == "quit")
            {
                return "quit";
            }
            else
            {

                if (userCommand.Length == 3)
                {

                    string result = FileCreation.CreateFile(userCommand[1], userCommand[2]);
                    if (result == "error")
                    {

                        return "error";
                    }
                    else
                    {
                        return "success";
                    }

                }
                else
                {
                    return "error command";
                }

            }

            
        }

        private static string CreateFile(string userURL, string userOutput)
        {

            Console.WriteLine("Awaiting your request be done...");

            WebClient wc = new WebClient();
            string theTextFile = wc.DownloadString(userURL);

            string[] lines = splitString(theTextFile, "\r\n");

            string outputLocation = userOutput.Replace("/", "\\");


            string fileName = @".\..\..\." + outputLocation;



            try
            {


                Directory.CreateDirectory(Path.GetDirectoryName(fileName));

                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file     
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine("#Version: 1.0");
                    sw.WriteLine("#Date: {0}", DateTime.Now.ToString());
                    sw.WriteLine("#Fields: provider http-method status-code uri-path time-taken response-size cache-status");

                    for (int i = 0; i < lines.Length - 1; i++)
                    {

                        //logFields[0] response-size
                        //logFields[1] status-code
                        //logFields[2] cache-status
                        //logFields[3] http-method uri-path
                        //logFields[4] time-taken
                        string[] logFields = splitString(lines[i], "|");
                        string httpAndUriPath = logFields[3];
                        //httpAndUriPathArray[0] http-method
                        //httpAndUriPathArray[1] uri-path
                        string[] httpAndUriPathArray = splitString(httpAndUriPath, " ");
                        //timeTakeSplitInDot[0] time-take before dot
                        //timeTakeSplitInDot[1] time-take after dot
                        string[] timeTakeSplitInDot = splitString(logFields[4], ".");

                        Log logAgora = new Log();
                        logAgora.provider = "\"MINHA CDN\"";
                        logAgora.httpMethod = httpAndUriPathArray[0].Replace("\"", "");
                        logAgora.statusCode = int.Parse(logFields[1]);
                        logAgora.uriPath = timeTakeSplitInDot[0];
                        logAgora.timeTaken = int.Parse(timeTakeSplitInDot[0]);
                        logAgora.responseSize = int.Parse(logFields[0]);
                        logAgora.cacheStatus = logFields[2];

                        sw.WriteLine(logAgora.provider + " " + logAgora.httpMethod + " " + logAgora.statusCode + " " + logAgora.uriPath + " " + logAgora.timeTaken + " " + logAgora.responseSize +
                                      " " + logAgora.cacheStatus);

                    }


                    return "success";


                }

            }
            catch (Exception Ex)
            {
                return "error";


            }

        }
    }
}
