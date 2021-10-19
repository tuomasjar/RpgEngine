using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGEngine;


namespace RPGEngine
{
    class Entity
    {
        public int HealthPoints { get; set; }

    }
    class Player : Entity
    {
        public String Name { get; set; }
        public Race race { get; set; }

        public String Description { get; set; }

        private List<Item> Inventory;

        private List<Item> Equipment;

        public int PickUpItem(Item item) //Add item to inventory if inventory is less than 25 items. Returns 0 when successfull
        {
            if(Inventory.Count >= Constants.MAX_INVENTORY)
            {
                Inventory.Add(item);
                return 0;
            }
            else
            {
                return 1;
            }
        }


        public int EquipItem(Item item) //Equips item. Unequips if something in slot already
        {
            switch (item.slot) //
            {
                case Slots.Head:
                    {
                        foreach (Item i in Equipment)
                        {
                            if (i.slot == Slots.Head)
                            {
                                Inventory.Add(i);
                                Equipment.Remove(i);
                                Equipment.Add(item);
                                return 0;
                            }
                        }
                        Equipment.Add(item);
                        return 0;
                    }
                case Slots.Torso:
                    {
                        foreach (Item i in Equipment)
                        {
                            if (i.slot == Slots.Torso)
                            {
                                Inventory.Add(i);
                                Equipment.Remove(i);
                                Equipment.Add(item);
                                return 0;
                            }
                        }
                        Equipment.Add(item);
                        return 0;
                    }
                case Slots.Legs:
                    {
                        foreach (Item i in Equipment)
                        {
                            if (i.slot == Slots.Legs)
                            {
                                Inventory.Add(i);
                                Equipment.Remove(i);
                                Equipment.Add(item);
                                return 0;
                            }
                        }
                        Equipment.Add(item);
                        return 0;
                    }
                case Slots.Boots:
                    {
                        foreach (Item i in Equipment)
                        {
                            if (i.slot == Slots.Boots)
                            {
                                Inventory.Add(i);
                                Equipment.Remove(i);
                                Equipment.Add(item);
                                return 0;
                            }
                        }
                        Equipment.Add(item);
                        return 0;
                    }
                case Slots.Weapon:
                    {
                        foreach (Item i in Equipment)
                        {
                            if (i.slot == Slots.Weapon)
                            {
                                Inventory.Add(i);
                                Equipment.Remove(i);
                                Equipment.Add(item);
                                return 0;
                            }
                        }
                        Equipment.Add(item);
                        return 0;
                    }
                case Slots.Shield:
                    {
                        foreach (Item i in Equipment)
                        {
                            if (i.slot == Slots.Shield)
                            {
                                Inventory.Add(i);
                                Equipment.Remove(i);
                                Equipment.Add(item);
                                return 0;
                            }
                        }
                        Equipment.Add(item);
                        return 0;
                    }
                case Slots.Item:
                    {
                        Inventory.Add(item);
                        return 0;
                        
                    }
                case Slots.Potion:
                    {
                        Inventory.Add(item);
                        return 0;
                        
                    }        
            }
            return 1;
        }
    }
    class Enemy : Entity
    {

    }
}
