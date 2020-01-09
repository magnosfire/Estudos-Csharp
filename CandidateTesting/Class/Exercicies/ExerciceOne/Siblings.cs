using System;
using System.Collections.Generic;
using System.Text;

namespace CandidateTesting.RenanRossinideOlivera.AgileExercices.Class
{
    public class Siblings
    {

        public static long siblingAnalyse(string typedNumber)
        {


            try
            {
                long verificationResult = VerifySiblings(typedNumber);
                return verificationResult;
            }
            catch (Exception)
            {

                return -2;

            }

        }

        private static long VerifySiblings(string path)
        {

            Numbers n = new Numbers();

            n.numberTyped = path;
            if (long.Parse(n.numberTyped) <= 2147483647)
            {

                n.largestNumber = int.Parse(path);

                long[] numbersArray = new long[path.Length];

                for (int i = 0; i < path.Length; i++)
                {
                    numbersArray[i] = int.Parse(path[i].ToString());
                }

                for (int i = 0; i < numbersArray.Length; i++)
                {

                    for (int c = i; c < numbersArray.Length; c++)
                    {

                        long[] newArray = numbersArray;

                        n.firstNumberToChange = newArray[i];
                        n.secondNumberToChange = newArray[c];

                        newArray[i] = n.secondNumberToChange;
                        newArray[c] = n.firstNumberToChange;

                        n.currentNumber = Int64.Parse(string.Join("", newArray));

                        if (n.largestNumber <= n.currentNumber)
                        {

                            n.largestNumber = n.currentNumber;

                        }

                    }


                }

                if (n.largestNumber >= 100000000)
                {

                    return -1;

                }
                else
                {

                    return n.largestNumber;

                }


            }
            else
            {
                return -3;

            }


        }
    }
}
