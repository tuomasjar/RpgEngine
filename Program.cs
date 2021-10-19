using System;

namespace RPGEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon sword = new Weapon("Pointy Stick",1,damageDice.d8);
            Player player1 = new Player();
            player1.Name = "Tuomas";
            player1.race = Race.Human;


            
        }
    }
}
