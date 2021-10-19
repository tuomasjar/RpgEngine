using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGEngine;



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

        public virtual void useItem()
        {

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

        public override void useItem(Enemy target)
        {

        }
        
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
