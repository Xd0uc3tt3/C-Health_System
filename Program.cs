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
            Console.ReadKey();
            Console.Clear();
            TakeDamage();
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
            else if (health >= 90)
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
            Console.Write("{0,58}", "Health:" + health + "/" + maxHealth);

            //Sheild
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("{0,17}", "Sheild:" + shield + "/" + maxShield);

            //Lives
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("{0,10}", "Lives:" + lives);

        }

        static void TakeDamage()
        {
            Random random = new Random();
            int damageAmount = random.Next(1, 26);

            if (shield != 0)
            {
                Console.WriteLine($"You took {damageAmount} amounts of damage to your Shield");
                shield -= damageAmount;
            }
            else
            {
                Console.WriteLine($"You took {damageAmount} amounts of damage to your health");
                health -= damageAmount;
            }

        }

        static void Heal()
        {
            //
        }

        static void RegenerateShield()
        {
            //
        }

        static void Revive()
        {
            if (lives > 0)
            {
                maxHealth = 100;
                health = maxHealth;

                maxShield = 100;
                shield = maxShield;

                lives -= 1;
            }
            else
            {
                GameOver();
            }
            
        }

        static void GameOver()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("{0,60}", "Game Over");
        }
    }
}
