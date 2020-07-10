using System;

namespace ReactionTimer
{
    class Program
    {
        static void Main(string[] args)
        {

            int trialcount = 2;
            int counter = trialcount;
            double[] trials = new double[trialcount];
            while (counter>0)
            {
                HelperFunctions.RandomWait(.5, 2);
               trials[counter-1] = HelperFunctions.PromptReaction("Now!");
                
               counter--;
            }
            double sumtime = 0;

            for (int i = 0; i < trialcount; i++) 
            {
                sumtime = sumtime + trials[i];
                
            }
            Console.WriteLine("The sum of trial times is: " + sumtime);
            Console.WriteLine("The average of the times was " + sumtime / trialcount + " miliseconds, or about " + ((60 * sumtime/2) / 1000) + " frames.");
            
            Console.ReadKey();
        }
    }
}
