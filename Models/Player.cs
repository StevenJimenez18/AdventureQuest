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

        public string name { get; set; }

        public string playerType { get; set; }

        public int attack { get; set; }

        public int defense { get; set; }

        public int health { get; set; }

        public int experience { get; set; }

        public int level { get; set; }

        public Player(string aName = "Defualt", string aPlayerType ="Defualt")
        {
            this.name = aName;

            this.playerType = aPlayerType;
            

            if(aPlayerType == "warrior")
            {
                this.attack = 75;
                this.defense = 25;
                this.health = 50;

            }

            if (aPlayerType == "orc")
            {
                this.attack = 35;
                this.defense = 100;
                this.health = 50;
            }

            if (aPlayerType == "mage")
            {
                this.attack = 25;
                this.defense = 15;
                this.health = 100;
            }
            

            this.experience = 0;

            this.level = 1;
        }

       
    }
}
