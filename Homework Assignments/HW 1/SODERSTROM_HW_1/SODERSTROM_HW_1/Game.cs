using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SODERSTROM_HW_1
{
    class Game
    {
        #region Fields

        const int BoardSize = 10;
        readonly List<Boat> boats = new List<Boat>();
        readonly BoardCell [,] cells = new BoardCell[BoardSize, BoardSize];
        bool allBoatsAreDead = false;

        #endregion

        #region Constructors

        public Game()
        {
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    cells[i,j] = new BoardCell();
                }
            }
        }

        #endregion

        #region Properties



        #endregion

        #region Methods

        public void BeginGameLoop()
        {
            // Setting the console settings
            Console.WindowWidth = 48;
            Console.WindowHeight = 30;
            Console.BufferWidth = 48;
            Console.BufferHeight = 30;
            Console.Title = "Luke's Battleship Game";

            // Ask for the user's name, and not give a shit
            Console.WriteLine();
            Console.Write("Enter your name: ");
            Console.ReadLine();

            // Create the boats
            boats.Add(new Boat(5));
            boats.Add(new Boat(4));
            boats.Add(new Boat(3));
            boats.Add(new Boat(3));
            boats.Add(new Boat(2));
            boats.Add(new Boat(2));
            PlaceBoatsByRandom(boats);

            // Master Game Loop
            while (!allBoatsAreDead)
            {
                UpdateVisuals();

                // Loop until user inputs a valid shot
                Pair2D userShot = null;
                while (userShot == null)
                {

                    // Ask for a shot
                    Console.WriteLine();
                    Console.Write("Enter a new shot: ");
                    string userInput = Console.ReadLine();

                    // Attempt to parse
                    userShot = ParseUserShotInput(userInput);

                    // Inform the user if their shot is invalid
                    if (userShot == null)
                    {
                        UpdateVisuals();
                        PlayInvalidEntrySound();
                        Console.WriteLine();
                        Console.WriteLine("(Invalid format)");
                    }
                    else
                    {
                        PlayProcessingVisualAndSound();
                    }
                }

                // Once the user has input valid data, make the shot
                MakeAShot(userShot.X, userShot.Y);
            }
        }

        void PlaceBoatsByRandom(List<Boat> boatList)
        {
            // Local Declarations
            List<Pair2D> coordinatesOwnedByBoatsAlready = new List<Pair2D>();
            Random rng = new Random();

            // Sort the bot list from largest to smallest
            boatList = boatList.OrderByDescending(boat => boat.Length).ToList();

            // Assign a random direction to each boat
            foreach (Boat boat in boatList)
            {
                //boat.Direction = (BoatDirection)rng.Next(0, 5);
                boat.Direction = BoatDirection.Up;
            }

            // Choose a location for each boat and set the coordinate pairs it owns
            foreach (Boat boat in boatList)
            {
                bool hasFoundOpenSpot = false;

                while (!hasFoundOpenSpot)
                {
                    // Choose a random starting point
                    int baseX = rng.Next(0, BoardSize);
                    int baseY = rng.Next(0, BoardSize);
                    Pair2D checkPair = new Pair2D(baseX, baseY);

                    switch (boat.Direction)
                    {
                        case BoatDirection.Up:
                            // First check if randomY - boat.Length is off the map
                            if (baseY - boat.Length < 0)
                            {
                                continue;
                            }

                            // Loop through the proposed cells and see if another boat owns it
                            for (int i = 0; i > boat.Length; i--)
                            {
                                checkPair.Y = baseY + i;

                                if (coordinatesOwnedByBoatsAlready.Contains(checkPair))
                                {
                                    continue;
                                }
                            }

                            // If we get here, go through those cells again and set the boat to own thos coordinates and add them to the already occupied list
                            hasFoundOpenSpot = true;
                            checkPair = new Pair2D(baseX, baseY);
                            for (int i = 0; i > boat.Length; i--)
                            {
                                checkPair.Y = baseY + i;

                                boat.CoordinatesOwned.Add(new Pair2D(checkPair.X, checkPair.Y));
                                coordinatesOwnedByBoatsAlready.Add(new Pair2D(checkPair.X, checkPair.Y));
                            }
                            break;

                        case BoatDirection.Right:
                            // First check if randomX + boat.Length is off the map
                            if (baseX + boat.Length >= BoardSize)
                            {
                                continue;
                            }

                            // Loop through the proposed cells and see if another boat owns it
                            for (int i = 0; i < boat.Length; i++)
                            {
                                checkPair.X = baseX + i;

                                if (coordinatesOwnedByBoatsAlready.Contains(checkPair))
                                {
                                    continue;
                                }
                            }

                            // If we get here, go through those cells again and set the boat to own thos coordinates and add them to the already occupied list
                            hasFoundOpenSpot = true;
                            checkPair = new Pair2D(baseX, baseY);
                            for (int i = 0; i < boat.Length; i++)
                            {
                                checkPair.X = baseX + i;

                                boat.CoordinatesOwned.Add(new Pair2D(checkPair.X, checkPair.Y));
                                coordinatesOwnedByBoatsAlready.Add(new Pair2D(checkPair.X, checkPair.Y));
                            }
                            break;

                        case BoatDirection.Down:
                            // First check if randomY - boat.Length is off the map
                            if (baseY + boat.Length >= BoardSize)
                            {
                                continue;
                            }

                            // Loop through the proposed cells and see if another boat owns it
                            for (int i = 0; i < boat.Length; i++)
                            {
                                checkPair.Y = baseY + i;

                                if (coordinatesOwnedByBoatsAlready.Contains(checkPair))
                                {
                                    continue;
                                }
                            }

                            // If we get here, go through those cells again and set the boat to own thos coordinates and add them to the already occupied list
                            hasFoundOpenSpot = true;
                            checkPair = new Pair2D(baseX, baseY);
                            for (int i = 0; i < boat.Length; i++)
                            {
                                checkPair.Y = baseY + i;

                                boat.CoordinatesOwned.Add(new Pair2D(checkPair.X, checkPair.Y));
                                coordinatesOwnedByBoatsAlready.Add(new Pair2D(checkPair.X, checkPair.Y));
                            }
                            break;

                        case BoatDirection.Left:
                            // First check if randomX - boat.Length is off the map
                            if (baseX - boat.Length < 0)
                            {
                                continue;
                            }

                            // Loop through the proposed cells and see if another boat owns it
                            for (int i = 0; i > boat.Length; i--)
                            {
                                checkPair.X = baseX + i;

                                if (coordinatesOwnedByBoatsAlready.Contains(checkPair))
                                {
                                    continue;
                                }
                            }

                            // If we get here, go through those cells again and set the boat to own thos coordinates and add them to the already occupied list
                            hasFoundOpenSpot = true;
                            checkPair = new Pair2D(baseX, baseY);
                            for (int i = 0; i > boat.Length; i--)
                            {
                                checkPair.X = baseX + i;

                                boat.CoordinatesOwned.Add(new Pair2D(checkPair.X, checkPair.Y));
                                coordinatesOwnedByBoatsAlready.Add(new Pair2D(checkPair.X, checkPair.Y));
                            }
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Takes the user input that is expected to be a letter and a number (in that order) and returns it, translated into a Pair2D. Will return null if anything else.
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        Pair2D ParseUserShotInput(string userInput)
        {
            // Local Declarations
            Pair2D returnPair = new Pair2D(0, 0);

            // Split up the  based on spaces
            char[] splitChecks = { ' ' };
            string[] splitString = userInput.Split(splitChecks, StringSplitOptions.RemoveEmptyEntries);

            // Go into the various cases
            switch (splitString.Length)
            {
                case 1:
                    // If the 0 element is perfectly a "letter then number" format
                    if (splitString[0].Length == 2 &&
                        splitString[0].ToUpper()[0] >= 'A' &&
                        splitString[0].ToUpper()[0] <= 'J' &&
                        int.TryParse(splitString[0][1].ToString(), out int numberValue0) &&
                        numberValue0 >= 0 &&
                        numberValue0 <= 9)
                    {
                        returnPair.X = splitString[0].ToUpper().ToCharArray()[0] - 'A';
                        returnPair.Y = numberValue0;

                        return returnPair;
                    }
                    else
                    {
                        return null;
                    }
                    break;

                case 2:
                    // If element 0 is the letter and element 1 is the number
                    if (splitString[0].Length == 1 &&
                        splitString[0].ToUpper()[0] >= 'A' &&
                        splitString[0].ToUpper()[0] <= 'J' &&
                        int.TryParse(splitString[1], out int numberValue1) &&
                        numberValue1 >= 0 &&
                        numberValue1 <= 9)
                    {
                        returnPair.X = splitString[0].ToUpper()[0] - 'A';
                        returnPair.Y = numberValue1;

                        return returnPair;
                    }
                    else
                    {
                        return null;
                    }
                    break;

                default:
                    return null;
            }
        }

        /// <summary>
        /// Checks to see if the passed in <paramref name="xShotAt"/> and <paramref name="yShotAt"/> coordinates are owned by any of the boats in <see cref="boats"/>, and if not, switches the cell to a "missed shot".
        /// </summary>
        /// <param name="xShotAt">The x coordinate.</param>
        /// <param name="yShotAt">The y coordinate.</param>
        Boat MakeAShot(int xShotAt, int yShotAt)
        {
            // For each boat in the list of boats
            foreach (Boat boat in boats)
            {
                // For each coordinate tuple in the boat's coordinate list
                foreach (Pair2D pair in boat.CoordinatesOwned)
                {
                    // If the boat owns the coordinates, go and make that corresponding BoardCell's value = 'x'
                    if (xShotAt == pair.X && yShotAt == pair.Y)
                    {
                        // Change the BoardCell's value to 'x'
                        cells[xShotAt, yShotAt].BoardState = 'x';

                        // Check to see if the boat is fully destroyed
                        return CheckForBoatFullyDestroyed(boat) ? boat : null;
                    }
                }
            }

            // If not, go and make that corresponding BoardCell's value = 'x'
            cells[xShotAt, yShotAt].BoardState = 'o';
            return null;

            // Local Functions
            bool CheckForBoatFullyDestroyed(Boat boat)
            {
                // Local Declarations
                bool isDestroyed = false;

                // Loop through each coordinate pair the boat owns
                foreach (Pair2D pair in boat.CoordinatesOwned)
                {
                    if (cells[pair.X, pair.Y].BoardState != 'x')
                    {
                        isDestroyed = false;
                    }
                }

                return isDestroyed;
            }
        }

        /// <summary>
        /// Clears the console and prints the game state with the new changes.
        /// </summary>
        void UpdateVisuals()
        {
            // Clear the console
            Console.Clear();

            // Print the top area of the game board
            SetColorsByDefault();
            Console.WriteLine("       0   1   2   3   4   5   6   7   8   9");
            PrintNeatPartition();

            // Print the whole game board
            for (char row = 'A'; row <= 'J'; row++)
            {
                SetColorsByDefault();
                Console.Write($" {row}   ");

                SetColorsByGrid();
                Console.Write("|");

                for (int col = 0; col < BoardSize; col++)
                {
                    // Logic for color change based on the character being printed
                    char printChar = cells[row - 'A', col].BoardState;
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
                SetColorsByDefault();
            }
            SetColorsByDefault();

            // Local Functions
            void PrintNeatPartition()
            {
                Console.WriteLine();
                SetColorsByDefault();
                Console.Write("     ");
                SetColorsByGrid();
                Console.Write("+---+---+---+---+---+---+---+---+---+---+");
                SetColorsByDefault();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Prints a processing message to the console and plays some beeps.
        /// </summary>
        void PlayProcessingVisualAndSound()
        {
            // Play the "processing" thing
            Console.Write("\nProcessing ");
            Thread.Sleep(30);
            for (int i = 0; i < 3; i++)
            {
                Console.Write(". ");
                Console.Beep(1200, 75);
                Thread.Sleep(70);
            }
        }

        /// <summary>
        /// Prints a boat death message and plays some beeps.
        /// </summary>
        void PlayDeathVisualAndSound()
        {
            // Printing
            Console.WriteLine();
            Console.WriteLine("A ship has been destroyed!");

            // The beeps
            Console.Beep(165, 70);
            Console.Beep(165, 70);
            Console.Beep(165, 70);
            Console.Beep(131, 800);
            Thread.Sleep(800);
        }

        /// <summary>
        /// Prints an invalid entry message and plays some correct beeps.
        /// </summary>
        void PlayInvalidEntrySound()
        {
            Console.Beep(600, 100);
            Console.Beep(600, 100);
        }

        /// <summary>
        /// Change the console background to <see cref="ConsoleColor.Black"/> and the foreground color to <see cref="ConsoleColor.White"/>
        /// </summary>
        public void SetColorsByDefault()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Change the console background to <see cref="ConsoleColor.DarkBlue"/> and the foreground color to <see cref="ConsoleColor.White"/>
        /// </summary>
        public void SetColorsByGrid()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
        }

        #endregion
    }
}
