using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuest.Models
{
    public class Player
    {
        [Key]
        int PlayerId { get; set; }

        string Name { get; set; }

        string PlayerType { get; set; }

        int Attack;

        int Defense; 

        int Health;

        int Experience;

        int Level;

        public Player(string aName, string aPlayerType)
        {
            this.Name = aName;

            this.PlayerType = aPlayerType;
            

            if(aPlayerType == "warrior")
            {
                this.Attack = 75;
                this.Defense = 25;
                this.Health = 50;

            }

            if (aPlayerType == "orc")
            {
                this.Attack = 35;
                this.Defense = 100;
                this.Health = 50;
            }

            if (aPlayerType == "mage")
            {
                this.Attack = 25;
                this.Defense = 15;
                this.Health = 100;
            }
            

            this.Experience = 0;

            this.Level = 0;
        }

    }
}
