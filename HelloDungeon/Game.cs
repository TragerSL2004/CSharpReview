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
        int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

        string GetInput(string prompt, string option1, string option2)
        {
            string playerChoice = "";
            while (playerChoice != "1" && playerChoice != "2")
            {
                Console.WriteLine(prompt);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);

                Console.Write("> ");
                playerChoice = Console.ReadLine();
                if (playerChoice != "1" && playerChoice != "2")
                {
                    Console.WriteLine("Stop wasting my time!");
                }
            }
            return playerChoice;
        }

        void ListBackwards(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
        void SumOfValues(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }
        void FizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++) 
            { 
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
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
            Spirit Jobbles = new Spirit(25f, "Jobbles the lonely ghost", 50f, 100f);

            Jobbles.Cry();
            return;
            FizzBuzz(15);
            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Now that I've finished countin my fizzy buzzes");
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
            playerInput = GetInput("How are you going to fight dem damn dirty demons?", "Like a Necromancer", "Like the Muffin Man");

            if (playerInput == "1")
            {
                Console.WriteLine("Destroy them like a Necromancer");
            }
            else if (playerInput == "2")
            {
                Console.WriteLine("Destroy them like the Muffin Man");
            }
            
        }
    }
}