using System;

namespace ReactionTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is just to show that changes update. 
            Console.WriteLine("Hello World!");
            double timeElapsed = HelperFunctions.PromptReaction("Go!");
            Console.WriteLine(timeElapsed);
            
        }
    }
}
