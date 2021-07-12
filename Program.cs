using AdventureQuest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Adventurer!");
            Console.WriteLine("Welcome to Adventure Quest.");
            Console.WriteLine("Lets get playing!");
            CreatePlayer();
        }

        static void CreatePlayer()
        {
            Console.Write("What is your adventurers name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine($"Welcome {playerName}!");
            Console.WriteLine($"What type of adventure would you like to be?");
            Console.WriteLine("Warrior - ATK:75 - DF:25 - Hlth:50");
            Console.WriteLine("Orc - ATK:35 - DF:100 - Hlth:50");
            Console.WriteLine("Mage - ATK:25 - DF:15 - Hlth:100");
            Console.Write("Please choice one - 1.Warrior - 2.Orc - 3.Mage: ");
            int playerChoice = Convert.ToInt32(Console.ReadLine());
            string playerType;
            switch (playerChoice)
            {
                case 1:
                    playerType = "warrior";
                    break;
                case 2:
                    playerType = "0rc";
                    break;
                case 3:
                    playerType = "mage";
                    break;
                default:
                    Console.WriteLine("You have made an invalid choice.");
                    break;
            }
            Player newPlayer = new Player(playerName, playerType);
        }
    }
}
