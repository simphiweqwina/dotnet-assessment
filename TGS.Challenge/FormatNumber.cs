using System;

namespace TGS.Challenge
{
    /*
        Devise a function that takes an input 'n' (integer) and returns a string that is the
        decimal representation of that number grouped by commas after every 3 digits. 
        
        NOTES: You cannot use any built-in formatting functions to complete this task.

        Assume: 0 <= n < 1000000000

        1 -> "1"
        10 -> "10"
        100 -> "100"
        1000 -> "1,000"
        10000 -> "10,000"
        100000 -> "100,000"
        1000000 -> "1,000,000"
        35235235 -> "35,235,235"

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class FormatNumber
    {
        public string Format(int value)
        {
            //check that value is vaild
            if (value == null || value < 0 ) { throw new ArgumentNullException();  }

            //check if has more than 3 characters
            if (value.ToString().Length <= 3 ) { return value.ToString(); }
            else
            {
                int numberOfCommas;
                char[] newWordArray = value.ToString().ToCharArray();
                numberOfCommas = newWordArray.Length / 3;

                Array.Resize(ref newWordArray, newWordArray.Length + numberOfCommas);


                
            }

            //format


            return string.Empty;
        }
    }
}
