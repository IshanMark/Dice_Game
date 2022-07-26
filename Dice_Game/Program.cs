﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Program
    {
        static int playerPoint = 0;
        static int enemyPoint = 0;

        static int playerRandomNum;
        static int enemyRandomNum;

        public static void checkWin()
        {
            if (playerRandomNum > enemyRandomNum)
            {
                playerPoint++;
                Console.WriteLine("Player wins this round!");
            }
            else if (playerRandomNum < enemyRandomNum)
            {
                enemyPoint++;
                Console.WriteLine("Enemy wins this round!");
            }
            else
            {
                Console.WriteLine("Draw!");
            }
        }

        public static void checkGame()
        {
            if (playerPoint < enemyPoint)
            {
                Console.WriteLine("You lost!\n");
            }
            else if (playerPoint > enemyPoint)
            {
                Console.WriteLine("You win!\n");
            }
            else
            {
                Console.WriteLine("It is a draw!\n");
            }
        }

        static void Main(string[] args)
        {

            Random random = new Random();

            int length = 10;
            for (int i = 0; i < length; i++)
            {

                Console.WriteLine("Press any key to roll the dice.");
                Console.ReadKey();
                Console.WriteLine();
                playerRandomNum = random.Next(1, 6);
                Console.WriteLine("You rolled a random number :  " + playerRandomNum);

                Console.WriteLine("....");
                System.Threading.Thread.Sleep(500);

                enemyRandomNum = random.Next(1, 6);
                Console.WriteLine("Enemy AI rolled a random number :  " + enemyRandomNum);

                checkWin();

                Console.WriteLine("The score is now - Player : " + playerPoint + " Enemy : " + enemyPoint);
                Console.WriteLine("\n");

            }

            checkGame();

            Console.ReadKey();

        }
    }
}