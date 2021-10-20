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

struct Position
{
    public int X { get; set; }
    public int Y { get; set; }

    public int distance(Position target)
    {
        double distance = 0.0f;
        int deltaX = this.X - target.X;
        int deltaY = this.Y - target.Y;
        distance = Math.Sqrt((deltaY * deltaY) + (deltaX * deltaX));
        int result = Convert.ToInt32(distance);
        return result;
    }
}
namespace RPGEngine
{
    static class Constants
    {
        public const int MAX_INVENTORY = 25;
        public const int SCREEN_WIDTH = 320;
        public const int SCREEN_HEIGHT = 240;
        public const char EMPTY_SYMBOL = ' ';
    }
}
