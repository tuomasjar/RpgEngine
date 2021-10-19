using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum Race
{
    Human,
    Elf,
    Halfling,
    Dwarf,
    Goblin,
    Orc,
    Kobold
}
enum Slots
{
    Head,
    Torso,
    Legs,
    Boots,
    Weapon,
    Shield,
    Potion,
    Item
}

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
    static class Constants
    {
        public const int MAX_INVENTORY = 25;

    }
}
