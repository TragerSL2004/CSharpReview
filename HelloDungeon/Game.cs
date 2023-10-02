using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        int currentArea;
        float health = 100f;
        string characterFirstName;
        string characterLastName;
        bool isAlive = true;
        string playerInput;
        double timeTilTurn;

        int Multiply(int a, int b)
        {
            int sum = a * b;
            return sum;
        }
        int GetSmallerNumber(int a, int b)
        {
            int SmallerNum = a;
            if (a > b)
            {
                SmallerNum = b;
            }
            else if (a < b)
            {
                SmallerNum = a;
            }
            else if (a == b)
            {
                Console.WriteLine("They are the same.");
            }
            return SmallerNum;
        }
        public void Run()
        {
            Console.WriteLine(GetSmallerNumber(1, 5));
            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Now that I've finished countin");
            Console.WriteLine("What we eatin today?");
            Console.WriteLine("Toast");
            Console.WriteLine("Pancake");
            Console.WriteLine("Sussy Baka");

            playerInput = Console.ReadLine();
            if (playerInput == "Toast")
            {
                Console.WriteLine("Egg");
            }
            else if (playerInput == "Pancakes")
            {
                Console.WriteLine("Bacon");
            }
            else if (playerInput == "Sussy Baka")
            {
                Console.WriteLine("You disgust me");
                Console.WriteLine("You get bonked into oblivion");
                health = 0;
            }
            else
            {
                Console.WriteLine("I can't eat that!!!");
            }
            if (health <= 0 || !isAlive)
            {
                Console.WriteLine("Get wr3cked n00b");
            }
            Console.WriteLine("How are you going to fight dem damn dirty demons?");
            Console.WriteLine("Like a Cowboy");
            Console.WriteLine("Like a Necromancer");
            Console.WriteLine("Like the Muffin Man");
            while (playerInput != "Cowboy" && playerInput != "Necromancer" && playerInput != "Muffin Man")
            {
                playerInput = "";
                playerInput = Console.ReadLine();
                if (playerInput == "Cowboy")
                {
                    Console.WriteLine("Destroy them like a Cowboy");
                }
                else if (playerInput == "Necromancer")
                {
                    Console.WriteLine("Destroy them like a Necromancer");
                }
                else if (playerInput == "Muffin Man")
                {
                    Console.WriteLine("Destroy them like the Muffin Man");
                }
                else
                {
                    Console.WriteLine("Those hairy demons will destroy you like that.");
                }
            }
        }
    }
}
