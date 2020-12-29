using System;

namespace OOP
{
    class Program
    {
        public static void Main(string[] args)
        {
            NonPlayable npc = new NonPlayable("John", 100f, 10f);
            npc.showInfo();
            Console.WriteLine();

            Hostile h = new Hostile("Martha", 200f, 20f, 25);
            h.showInfo();
            Console.WriteLine();

            Turret cannon = new Turret("Cannon", 150f, 0f, 50, 1, 5f, "Cannonball");
            cannon.showInfo();
            for(int i = 0; i < 4; i++)
            {
                cannon.shoot();
            }
            Console.WriteLine();

            //The Hostile's showInfo will be invoked, unless we use the virtual and override keywords in the base and derived class
            Hostile android = new Turret("Andro", 50f, 20f, 40, 10, 2f, "Bullets");
            android.showInfo();
            Console.WriteLine();

            Slime s1 = new Slime();
            s1.showInfo();
            Console.WriteLine();

            //Bye bye everyone!
            npc.deathSound();
            h.deathSound();
            cannon.deathSound();
            android.deathSound();
            s1.deathSound();

        }
    }
}
