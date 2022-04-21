using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasicsAssignment.Models
{
    public class Game
    {
        public static string CheckGame(int guessNumber, int randomNumber)
        {
            string result = "";

            if (randomNumber == guessNumber)
            {
                result = "Hurray! Your guessed number is correct.";
            }

            else if (guessNumber < randomNumber)
            {
                result = "Sorry!Your guessed number is too low.";

            }

            else if (guessNumber > randomNumber)
            {
                result = "Your guessed number is too high.";

            }

            return result;

        }
        public static int GetRandom(int max)
        {
            Random rnd = new Random();
            return rnd.Next(1, max);
        }
    }
}