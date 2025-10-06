using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem
{
    internal class Program
    {

        static int maxHealth = 100;
        static int health = maxHealth;

        static int maxShield = 100;
        static int shield = maxShield;

        static int lives = 3;
        static void Main(string[] args)
        {
            ShowHud();

        }

        static void ShowHud()
        {
            string characterName = "Brutus Jr";


            //Character Name
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("{0,0}", characterName);

            //Health Status
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (health == 100)
            {
                Console.Write("{0,25}", "Perfect Health");
            }
            else if (health >= 75)
            {
                Console.Write("{0,25}", "Healthy");
            }
            else if (health >= 50 && health <= 75)
            {
                Console.Write("{0,25}", "Hurt");
            }
            else if (health >= 10 && health <= 50)
            {
                Console.Write("{0,25}", "Badly Hurt");
            }
            else if (health >= 0 && health <= 10)
            {
                Console.Write("{0,25}", "Immeniate Danger");
            }
            else
            {
                Console.Write("{0,65}", "InValid Health Status");
            }

            //Health
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0,60}", "Health:" + health + "/" + maxHealth);

            //Weapon
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("{0,17}", "Sheild:" + shield + "/" + maxShield);

            //Score
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("{0,10}", "Lives:" + lives);

        }
    }
}
