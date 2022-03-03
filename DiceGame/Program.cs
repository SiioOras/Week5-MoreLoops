using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti ehk (cpu) ja kasutaja ehk (user);
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem;
            //mängija, kes viskab rohkem, on võitja;
            //*täringuid visatakse kolm korda;
            //programm kuulutab võitja.

            Random rnd = new Random();

            

            int cpuScore = 0; //skoorid
            int userScore = 0;


            for (int i = 0; i < 3; i++)
            {
                int cpuRandom = rnd.Next(1, 7); //arvuti vise
                int userRandom = rnd.Next(1, 7); //kasutaja vise    

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");

                if (cpuRandom < userRandom)
                {
                    Console.WriteLine($"Kasutaja on mängu võitnud. Kasutaja võitude skoor on {userScore + 1}. Palju õnne!");
                    userScore = userScore + 1;

                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine($"Arvuti on mängu võitnud. Arvuti võitude skoor on {cpuScore + 1}. Palju õnne!");
                    cpuScore = cpuScore + 1;
                }
                else
                {
                    Console.WriteLine("Viik!");
                }

            }

        }
    }
}
