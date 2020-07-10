using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace ReactionTimer
{
    static class HelperFunctions
    {
        // This function prompts a reaction, then starts a timer. It stops the timer after a key is pressed, then returns the timer value. 
        public static double PromptReaction(string prompt) 
        {
            Console.WriteLine(prompt);
            //Creating a stopwatch
            Stopwatch ReactionTimer = new Stopwatch();
            ReactionTimer.Start();
            
            //This has the intercept argument be true, to suppress the key output. 
            Console.ReadKey(true);
            ReactionTimer.Stop();
            return Convert.ToDouble(ReactionTimer.ElapsedMilliseconds);
            
        }

        //RandomWait - waits between x and y seconds before doing something. 
        public static void RandomWait(double minTime, double maxTime) 
        {
            Random rng = new Random();
            double wait = rng.NextDouble() * (maxTime - minTime) + minTime;
            int waitMiliseconds = Convert.ToInt32(wait * 1000);
            System.Threading.Thread.Sleep(waitMiliseconds);
        }
    }
}
