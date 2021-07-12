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

        public string Name { get; set; }

        public string PlayerType { get; set; }

        public int Attack;

        public int Defense; 

        public int Health;

        public int Experience;

        public int Level;

        public Player(string aName = "Defualt", string aPlayerType ="Defualt")
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
