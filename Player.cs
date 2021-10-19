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
    Dwarf
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

namespace RPGEngine
{
    class Player
    {
        public String Name { get; set; }
        public Race race { get; set; }

        public String description { get; set; }

        List<Item> inventory;

        List<Item> equipment;

        public int PickUp(Item item)
        {
            switch (item.slot)
            {
                case Slots.Head:
                    {
                        bool equipped = false;
                        foreach (Item i in equipment)
                        {
                            if (i.slot == Slots.Head) equipped = true;
                        }
                        if (!equipped)
                        {
                            equipment.Add(item);
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                case Slots.Torso:
                    {
                        bool equipped = false;
                        foreach (Item i in equipment)
                        {
                            if (i.slot == Slots.Torso) equipped = true;
                        }
                        if (!equipped)
                        {
                            equipment.Add(item);
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                case Slots.Legs:
                    {
                        bool equipped = false;
                        foreach (Item i in equipment)
                        {
                            if (i.slot == Slots.Legs) equipped = true;
                        }
                        if (!equipped)
                        {
                            equipment.Add(item);
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                case Slots.Boots:
                    {
                        bool equipped = false;
                        foreach (Item i in equipment)
                        {
                            if (i.slot == Slots.Boots) equipped = true;
                        }
                        if (!equipped)
                        {
                            equipment.Add(item);
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                case Slots.Weapon:
                    {
                        bool equipped = false;
                        foreach(Item i in equipment)
                        {
                            if (i.slot == Slots.Weapon) equipped = true;
                        }
                        if (!equipped)
                        {
                            equipment.Add(item);
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                        
                    }
                case Slots.Shield:
                    {
                        bool equipped = false;
                        foreach(Item i in equipment)
                        {
                            if (i.slot == Slots.Shield) equipped = true;
                        }
                        if (!equipped)
                        {
                            equipment.Add(item);
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                        
                    }
                case Slots.Item:
                    {
                        inventory.Add(item);
                        return 0;
                        
                    }
                case Slots.Potion:
                    {
                        inventory.Add(item);
                        return 0;
                        
                    }

                             
            }

            return 1;
        }
    }
}
