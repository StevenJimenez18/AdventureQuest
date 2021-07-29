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
            Player newPlayer = CreatePlayer();
            Console.WriteLine($"Hello: {newPlayer.name}");
            Console.WriteLine($"Your player type is {newPlayer.playerType}");
            Console.WriteLine($"your attack power is {newPlayer.attack}");
            Console.WriteLine($"your defense power is {newPlayer.defense}");
            Menu(newPlayer);
            Console.ReadLine();
        }

        static Player CreatePlayer()
        {
            Console.Write("What is your adventurer's name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine($"Welcome {playerName}!");
            Console.WriteLine($"What type of adventurer would you like to be?");
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

        static Enemy CreateEnemy(Player player)
        {
            Random rand = new Random();

            int enemyLevel = rand.Next(player.level, player.level + 2);
            int enemyExperience = (int)(enemyLevel / .25);

            int enemyType = rand.Next(1, 3);

            if(enemyType == 1)
            {
                string type = "warrior";
                int enemyAttack = rand.Next(player.attack, (int)(player.attack / .6));
                int enemyDefense = rand.Next(player.defense, (int)(player.defense / .8));
                int enemyHeatlh = rand.Next(player.health, (int)(player.health / .8));
                Enemy newEnemy = new Enemy(type, enemyAttack, enemyDefense, enemyHeatlh, enemyExperience, enemyLevel);
                return newEnemy;
            }
            if (enemyType == 2)
            {
                string type = "orc";
                int enemyAttack = rand.Next(player.attack, (int)(player.attack / .8));
                int enemyDefense = rand.Next(player.defense, (int)(player.defense / .6));
                int enemyHeatlh = rand.Next(player.health, (int)(player.health / .8));
                Enemy newEnemy = new Enemy(type, enemyAttack, enemyDefense, enemyHeatlh, enemyExperience, enemyLevel);
                return newEnemy;
            }
            if (enemyType == 1)
            {
                string type = "mage";
                int enemyAttack = rand.Next(player.attack, (int)(player.attack / .8));
                int enemyDefense = rand.Next(player.defense, (int)(player.defense / .8));
                int enemyHeatlh = rand.Next(player.health, (int)(player.health / .6));
                Enemy newEnemy = new Enemy(type, enemyAttack, enemyDefense, enemyHeatlh, enemyExperience, enemyLevel);
                return newEnemy;
            }

            return null;

        }

        static void Menu(Player player)
        {
            Console.WriteLine("What would you like to do?");
            Console.Write("1.Explore 2.Eat 3.Rest: ");
            int playerChoice = Convert.ToInt32(Console.ReadLine());
            if (playerChoice == 1)
            {
                Explore(player);
            }
            if (playerChoice == 2)
            {
                
            }
            if (playerChoice == 3)
            {
                
            }
        }

        static void Explore(Player player)
        {
            Random rand = new Random();
            Enemy createEnemy = CreateEnemy(player);
            int action = rand.Next(0, 10);
            if(action <= 4)
            {
                Fight(player, createEnemy);
                
            }
            else if( action > 4 && action <= 6 )
            {
                //find treasure
            }
            else if(action > 6 && action <= 8)
            {
                //encounter storm
            }
            else
            {
                //find food
            }
            //fight monster
            //find treasure for exp
            //encounter storm lose health
            //find food - may gain health may lose health
        }

        static void Fight(Player player, Enemy enemy)
        {
            Console.WriteLine($"You have encountered an enemy {enemy.monsterType}");
            Console.WriteLine("get ready to fight!");
            Random rand = new Random();
            while (player.health > 1 || enemy.health > 1)
            {
                int action = rand.Next(1, 10);
                Console.Write("Actions: 1.Attack 2.Defend 3.Flee: ");
                int playerResponse = Convert.ToInt32(Console.ReadLine());
                if(playerResponse == 1)
                {
                    Console.WriteLine($"You attacked the enemy {enemy.monsterType}");
                    if(action % 2 == 0)
                    {
                        int hitamount = player.attack - enemy.defense;
                        enemy.health = enemy.health - hitamount;
                        Console.WriteLine($"Your hit landed successfully for {hitamount}");
                        Console.WriteLine($"The enemys health is now {enemy.health}");
                    }
                    else
                    {
                        Console.WriteLine("Oh no! your attacked missed!");
                    }

                }
                Console.WriteLine("Get ready it's the enemy's turn!");
                int enemyAction = rand.Next(1, 7);
                if(enemyAction % 2 == 1)
                {
                    Console.WriteLine($"The enemy {enemy.monsterType} attacked!");
                    if (action % 2 == 1)
                    {
                        int hitamount = enemy.defense - player.attack;
                        player.health = player.health - hitamount;
                        Console.WriteLine($"The enemy {enemy.monsterType}'s hit landed successfully for {hitamount}");
                        Console.WriteLine($"Your health is now {player.health}");
                    }
                    else
                    {
                        Console.WriteLine("Oh no! your attacked missed!");
                    }
                }
            }
        }

        static void Train()
        {
            //gain attack
            //gain defense
            //gain health
        }

        static void Rest()
        {
            //restore health
        }
    }
}
