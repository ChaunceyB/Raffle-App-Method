using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        private static Dictionary<int, string> guests = new Dictionary<int, string> {};

        private static int min = 1000;
        private static int max = 9999;
        private static int raffleNumber;
        private static Random _rdm = new Random();

        static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return message = Console.ReadLine();
        }

        static int GenerateRandomNumber(int min, int max)
        {
            return _rdm.Next(min, max);
        }

        static void AddGuestsInRaffle( int raffleNumber, string guest)
        {
            guests.Add(raffleNumber, guest);
        }
        static void PrintGuestName()
        {
            foreach(KeyValuePair<int,string> name in guests)
            {
                Console.WriteLine(name);
            }
        }
        static int GetRaffleNumber(Dictionary<int, string> winner)
        {
           int index = _rdm.Next(0, winner.Count);
           return winner.Keys.ElementAt(index);      
        }
        static void PrintWinner()
        {
            int winnerNumber = GetRaffleNumber(guests);
            string winnerName = guests[winnerNumber];
            Console.WriteLine($"The Winner is: {winnerName} with the #{winnerNumber}");
        }
        static void GetUserInfo()
        {
            string guestName = "";
            string newGuest = "";
            do
            {
                guestName = GetUserInput("Please enter a name:");

                //raffleNumber = GenerateRandomNumber(1000, 10000);
                //Console.WriteLine(raffleNumber);
              
                if(guestName == "")
                {
                    continue;
                }
                newGuest = GetUserInput("Do you want to enter another name?");
                
                raffleNumber = GenerateRandomNumber(1000, 10000);
                //validate random number, if random number is duplicated iterate until it isn't

                //add rafflenumber and guestname to dictionary. this can be done with AddGuestsInRaffle() method 

                AddGuestsInRaffle(raffleNumber, guestName);

            }
            while (newGuest.ToLower() != "no"); 

            
           
        }
        static void Main(string[] args)
        {
            //GetUserInfo();
            Console.WriteLine("Welcome to the Party!!");
            GetUserInfo();
            PrintGuestName();
            PrintWinner();


        }

        //Start writing your code here






        static void MultiLineAnimation() // Credit: https://www.michalbialecki.com/2018/05/25/how-to-make-you-console-app-look-cool/
        {
            var counter = 0;
            for (int i = 0; i < 30; i++)
            {
                Console.Clear();

                switch (counter % 4)
                {
                    case 0:
                        {
                            Console.WriteLine("         ╔════╤╤╤╤════╗");
                            Console.WriteLine("         ║    │││ \\   ║");
                            Console.WriteLine("         ║    │││  O  ║");
                            Console.WriteLine("         ║    OOO     ║");
                            break;
                        };
                    case 1:
                        {
                            Console.WriteLine("         ╔════╤╤╤╤════╗");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    OOOO    ║");
                            break;
                        };
                    case 2:
                        {
                            Console.WriteLine("         ╔════╤╤╤╤════╗");
                            Console.WriteLine("         ║   / │││    ║");
                            Console.WriteLine("         ║  O  │││    ║");
                            Console.WriteLine("         ║     OOO    ║");
                            break;
                        };
                    case 3:
                        {
                            Console.WriteLine("         ╔════╤╤╤╤════╗");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    OOOO    ║");
                            break;
                        };
                }

                counter++;
                Thread.Sleep(200);
            }
        }
    }
}
