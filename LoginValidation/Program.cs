using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna;
            //kui sisestatud kasutajatunnus on admin ja sisestatud salasõna admin1234, siis programmi konsoolis kuvatakse "Tere tulemast!";
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti!"
            //kasutajal on 3 katset, i < 3

            int i = 0;

            while(i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna:");
                string userPass = Console.ReadLine();

                if (userName == "admin" && userPass == "admin1234") //AND = &&
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale kasutajatunnus või salasõna. {3 - i} katset jäänud!");
                }
            }
        }
    }
}
