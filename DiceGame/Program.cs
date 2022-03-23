using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user);
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem;
            //mängija, kes viskab rohkem, ongi mängu võitja.
            //*täringuid visatakse kolm korda;
            //programm kuulutab võitjat


            Random rnd = new Random();

            

            int cpuScore = 0;
            int userScore = 0;

            for (int i = 0; i < 3; i++)
            {
                //arvuti vise
                int cpuRandom = rnd.Next(1, 7);
                //kasutaja vise
                int userRandom = rnd.Next(1, 7);

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");

                if (cpuRandom < userRandom)
                {                    
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    cpuScore = cpuScore + 1;
                }

            }
            if (cpuScore < userScore)
            {
                Console.WriteLine($"Kasutaja on {userScore} punktiga mängu võitnud. Palju õnne!");
                userScore = userScore + 1;
            }
            else if (cpuScore > userScore)
            {
                Console.WriteLine($"Arvuti on {cpuScore} punktiga mängu võitnud!");
                cpuScore = cpuScore + 1;
            }
            else
            {
                Console.WriteLine("Viik!");
            }



        }
    }
}
