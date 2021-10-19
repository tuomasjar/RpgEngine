using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGEngine;

enum damageDice
{
    d4,
    d6,
    d8,
    d10,
    d12,
    d20
}

namespace RPGEngine
{
    class Item
    {
        
        public String Description { get; set; }

        public int Enchantment { get; set; }

        public Slots slot { get; init; }
        public Item(Slots slot)
        {
            this.slot = slot;
        }
    }

    class Weapon : Item
    {
        public Weapon(String description, int enchant,damageDice dice) : base(Slots.Weapon)
        {
            this.Description = description;
            this.Enchantment = enchant;
            this.dmgDice = dice;
           

        }
        public damageDice dmgDice { get; init; }

        
    }

    class Shield : Item
    {
        public int Defence { get; init; }
        public Shield(int defence):base(Slots.Shield)
        {
            this.Defence = defence;
        }
    }
}
