using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuest
{
    class Enemy
    {
        public string monsterType { get; set; }

        public int attack { get; set; }

        public int defense { get; set; }

        public int health { get; set; }

        public int experience { get; set; }

        public int level { get; set; }

        public Enemy(string aMonsterType, int aAttack, int aDefense, int aHealth, int aExperience, int aLevel)
        {

        }


    }
}
