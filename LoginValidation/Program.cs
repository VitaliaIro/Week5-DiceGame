using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnust ja salasõna;
            //kui sisestatud kasutajatunnus on "admin" ja salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast";
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti.".
            //kasutajal on 3 katset

            int i = 0;

            while (i < 3) 
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna:");
                string userPassword = Console.ReadLine();

                if (userName != "admin" || userPassword != "admin1234")
                {
                    i++;
                    Console.WriteLine($"Vale kasutajatunnus või salasõna. Proovi uuesti.{3 - i} katset on jäänud.");
                }
                else
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }


              

            }
            
        }
    }
}
