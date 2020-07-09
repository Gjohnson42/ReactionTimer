using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Stopwatch ReactionTimer = new Stopwatch;
            ReactionTimer.Start();
            Console.ReadKey();
            ReactionTimer.Stop();
            return ReactionTimer.ElapsedMilliseconds;
            
        }
    }
}
