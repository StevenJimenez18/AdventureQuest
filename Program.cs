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
            /*Player newPlayer = new Player();
            Console.WriteLine($"Hello: {newPlayer.Name}");*/
            Player newPlayer = CreatePlayer();
            Console.WriteLine($"Hello: {newPlayer.Name}");
            Console.WriteLine($"Your player type is {newPlayer.PlayerType}");
            Console.WriteLine($"your attack power is {newPlayer.Attack}");
            Console.WriteLine($"your defense power is {newPlayer.Defense}");
            Console.ReadLine();
        }

        static Player CreatePlayer()
        {
            Console.Write("What is your adventurers name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine($"Welcome {playerName}!");
            Console.WriteLine($"What type of adventure would you like to be?");
            Console.WriteLine("Warrior - ATK:75 - DF:25 - Hlth:50");
            Console.WriteLine("Orc - ATK:35 - DF:100 - Hlth:50");
            Console.WriteLine("Mage - ATK:25 - DF:15 - Hlth:100");
            Console.Write("Please choose one - 1.Warrior  2.Orc  3.Mage: ");
            int playerChoice = Convert.ToInt32(Console.ReadLine());
            string playerType;
            Player newPlayer;
            if (playerChoice == 1)
            {
                playerType = "warrior";
                newPlayer = new Player(playerName, playerType);
                return newPlayer;
            }
            if (playerChoice == 2)
            {
                playerType = "orc";
                newPlayer = new Player(playerName, playerType);
                return newPlayer;
            }
            if (playerChoice == 3)
            {
                playerType = "mage";
                newPlayer = new Player(playerName, playerType);
                return newPlayer;
            }

            return null;
            
        }
    }
}
