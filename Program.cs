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

        static bool isAlive = true;
        static void Main(string[] args)
        {

            ShowHud();

            while (isAlive == true)
            {
                Console.ReadKey();

                Random random = new Random();
                int nextMove = random.Next(1, 11);

                if (nextMove <= 8)
                {
                    Console.Clear();
                    TakeDamage(nextMove);
                    ShowHud();
                }
                else if (nextMove == 9)
                {
                    Console.Clear();
                    Heal(nextMove);
                    ShowHud();
                }
                else
                {
                    Console.Clear();
                    RegenerateShield(nextMove);
                    ShowHud();
                }
            }

            GameOver();

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
            else if (health >= 50 && health <= 90)
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

        static void TakeDamage(int damageAmount)
        {

            if (shield != 0)
            {
                Console.WriteLine($"You took {damageAmount} amounts of damage to your Shield");
                shield -= damageAmount;

                if (shield <= 0)
                {
                    health += shield;
                    shield = 0;
                }
            }
            else if (shield == 0)
            {
                Console.WriteLine($"You took {damageAmount} amounts of damage to your health");
                health -= damageAmount;

                if (health <= 0)
                {
                    health = 0;
                }
            }

            if (health <= 0)
            {
                Revive();
            }

        }

        static void Heal(int healAmount)
        {

            if (health <= 99)
            {
                Console.WriteLine($"You restored {healAmount} amounts of damage to your health");
                health += healAmount;

            }
            else
            {
                health = 100;
                Console.WriteLine("You tried to heal your health, but your health is full");
            }

            if (health >= 100)
            {
                health = 100;
            }
        }

        static void RegenerateShield(int regenShieldAmount)
        {

            if (shield <= 99)
            {
                Console.WriteLine($"You restored {regenShieldAmount} amounts of damage to your shield");
                shield += regenShieldAmount;

            }
            else
            {
                shield = 100;
                Console.WriteLine("You tried to heal your shield, but your sheild is full");
            }

            if (shield >= 100)
            {
                shield = 100;
            }
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

                Console.WriteLine("You died and used a revive");
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
