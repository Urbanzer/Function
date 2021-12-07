using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //kysib eesnime
            //kysib numbrit 1-3
            //kui 1, kuvatakse tagurpidi 
            //2, esimest tahte
            //3, nimi tagurpidi

            Console.WriteLine("sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("sisesta number 1-3");
            char userNumber = Convert.ToChar(Console.ReadLine());

            GetUserNameData(userName, userNumber);


        }





        public static void GetUserNameData(string userName, char userNumber)
        {
            switch (userNumber)
            {
                case '1':
                    for (int i = userName.Length - 1; i >= 0; i--)
                    {
                        Console.Write(userName[i]);
                    }
                    break;
                case '2':
                    char firstCharacter = userName[0];
                    Console.WriteLine($"Sinu eesnime taht on {firstCharacter}");
                    break;
                case '3':
                    Console.WriteLine($"Sinu nimi on {userName.Length} sumbolit pikk.");
                    break;
                default:
                    Console.WriteLine("Kena paeva!");
                    break;

            }

        }
    }



}

