using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuest.Models
{
    public class CharacterModel
    {
        public string Type { get; set; }

        public int attack { get; set; }

        public int defense { get; set; }

        public int health { get; set; }

        public int experience { get; set; }

        public int level { get; set; }
    }
}
