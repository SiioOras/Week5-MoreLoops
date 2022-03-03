using System;

namespace OrOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna;
            //kui sisestatud kasutajatunnus on admin ja sisestatud salasõna admin1234, siis programmi konsoolis kuvatakse "Tere tulemast!";
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti!"

            //OR (või) || 
            
            //true || true --> true
            //false || true --> true
            //true || false --> true
            //false || false --> false
            
            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string userPass = Console.ReadLine();

            if(userName != "admin" || userPass != "admin1234") //! tähendab EI
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti!");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }

            //"admin1" != "admin" || "admin1234" != "admin1234" --> true || false
            //"admin" != "admin" || "admin 123" != "admin1234" --> false || true
            //"admin1" != "admin" || "admin123" != "admin1234" --> true || true
            //"admin" != "admin" || "admin1234" != "admin1234" --> false || false


        }
    }
}
