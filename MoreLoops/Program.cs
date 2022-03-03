using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna;
            //kui sisestatud kasutajatunnus on admin ja sisestatud salasõna admin1234, siis programmi konsoolis kuvatakse "Tere tulemast!";
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti!"

            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string userPass = Console.ReadLine();
            
            //AND või OR 

            //"admin" AND "admin1234" --> true
            //"admin1" AND "admin1234" --> false
            //"admin" AND "admin1" --> false
            //"admin1" AND "admin12" --> false

            if (userName == "admin" && userPass == "admin1234") //AND = &&
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti!");
            }





        }
    }
}
