using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace teaching2
{
    class Program
    {
        // Class Level Constants
        const int GridSize = 10;

        static void Main(string[] args)
        {

            Random rng = new Random();

            // Setting the console settings
            Console.WindowWidth = 47;
            Console.WindowHeight = 30;
            Console.BufferWidth = 47;
            Console.BufferHeight = 30;
            Console.Title = "Luke's Battleship Game";


            char [,] gridList = new char[GridSize, GridSize];

            // Filling the array
            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    switch (rng.Next(12))
                    {
                        case 0:
                            gridList[i, j] = 'o';
                            break;
                        case 1:
                            gridList[i, j] = 'x';
                            break;
                        case 2:
                            gridList[i, j] = 's';
                            break;
                        default:
                            gridList[i, j] = ' ';
                            break;
                    }
                }
            }

            PrintGrid(gridList);
        }

        public static void PrintGrid(char [,] list)
        {
            SetColorsByDefault();
            Console.WriteLine("      0   1   2   3   4   5   6   7   8   9");
            PrintNeatPartition();

            for (char row = 'A'; row <= 'J'; row++)
            {
                SetColorsByDefault();
                Console.Write($" {row}   ");

                SetColorsByGrid();
                Console.Write("|");

                for (int col = 0; col < GridSize; col++)
                {
                    // Logic for color change based on the character
                    char printChar = list[row - 'A', col];
                    switch (printChar)
                    {
                        case 'o':
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;

                        case 'x':
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;

                        case 's':
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                    }

                    Console.Write($" {printChar} ");
                    SetColorsByGrid();
                    Console.Write("|");
                }

                PrintNeatPartition();
            }
            SetColorsByDefault();

            // Local Functions
            void PrintNeatPartition()
            {
                Console.WriteLine();
                SetColorsByDefault();
                Console.Write("     ");
                SetColorsByGrid();
                Console.WriteLine("+---+---+---+---+---+---+---+---+---+---+");
            }
        }

        public static void SetColorsByDefault()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void SetColorsByGrid()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
