using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace SODERSTROM_HW_1
{
    class Game
    {
        #region Fields

        const int BoardSize = 10;
        readonly List<Boat> boats = new List<Boat>();
        readonly BoardCell [,] cells = new BoardCell[BoardSize, BoardSize];
        bool allBoatsAreDead;
        int deadBoatCount;
        const int ConsoleWidth = 48;
        const int ConsoleHeight = 34;

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

        /// <summary>
        /// Opens the game menu.
        /// </summary>
        public void OpenGameMenu()
        {
            // Initial Settings
            allBoatsAreDead = false;
            deadBoatCount = 0;
            FlushBoard();

            // Setting the console settings
            Console.WindowWidth = ConsoleWidth;
            Console.WindowHeight = ConsoleHeight;
            Console.BufferWidth = ConsoleWidth;
            Console.BufferHeight = ConsoleHeight;
            Console.Title = "Luke's Battleship Game";

            // Begin Menu Loop

            while (!allBoatsAreDead)
            {
                // Print menu
                Console.Clear();
                PresentMainMenu();
                Console.CursorVisible = false;
                char.TryParse(Console.ReadKey().KeyChar.ToString().ToUpper(), out char userChoice);
                Console.CursorVisible = true;

                // Process entry
                switch (userChoice)
                {
                    case 'B':
                        BeginGameNormally();
                        break;
                    case 'G':
                        BeginGameInGradingMode();
                        break;
                    case 'Q':
                        Environment.Exit(0);
                        break;
                }
            }

            // Local Functions
            void PresentMainMenu()
            {
                Console.Clear();

                // Intro text
                Console.WriteLine();
                PrintCentered("Welcome to Luke's Battleship\n\n", ConsoleWidth);
                PrintCentered("- - - - - - - - - - - - - - - - - -\n\n", ConsoleWidth);

                // Present Manu options
                PrintLeftJust("B - Begin Game (in normal mode)\n", ConsoleWidth);
                PrintLeftJust("G - Begin Game (in Chris' grading mode)\n", ConsoleWidth);
                PrintLeftJust("Q - Quit Game\n", ConsoleWidth);

            }

            void BeginGameNormally()
            {
                Console.Clear();

                // Create the boats
                boats.Add(new Boat(5));
                boats.Add(new Boat(4));
                boats.Add(new Boat(3));
                boats.Add(new Boat(3));
                boats.Add(new Boat(2));
                boats.Add(new Boat(2));
                PlaceBoatsByRandom(boats);

                // Start the game
                MasterGameLoop();
            }

            void BeginGameInGradingMode()
            {
                Console.Clear();

                // Create the boats
                boats.Add(new Boat(5));
                boats.Add(new Boat(4));
                boats.Add(new Boat(3));
                boats.Add(new Boat(3));
                boats.Add(new Boat(2));
                boats.Add(new Boat(2));
                PlaceBoatsByRandom(boats);
                ForceCellsByGradingMode();

                // Start the game
                MasterGameLoop();
            }
        }

        /// <summary>
        /// Master Game Loop to run the game
        /// </summary>
        public void MasterGameLoop()
        {
            // Ask for the user's name, and not give a shit
            Console.WriteLine();
            Console.Write("Enter your name: ");
            Console.ReadLine();

            // First initializations
            UpdateInGameVisual();
            Stopwatch gameTimer = new Stopwatch();
            gameTimer.Start();

            // Master Game Loop
            while (!allBoatsAreDead)
            {
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
                        UpdateInGameVisual();
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
                bool killedBoat = MakeAShot(userShot.X, userShot.Y);

                // Update the visuals and check to see if all the boats are dead
                UpdateInGameVisual();
                allBoatsAreDead = true;
                foreach (Boat boat in boats)
                {
                    if (!boat.IsDestroyed)
                    {
                        allBoatsAreDead = false;
                    }
                }

                // Stop the gameTimer if all the boats are daed
                if (allBoatsAreDead)
                {
                    gameTimer.Stop();
                }

                // If a boat is destroyed, play the death sound and inform the user what kind of boat they've killed
                if (killedBoat)
                {
                    PlayBoatDestroyedVisualAndSound();
                }
            }

            // Go into Victoy Visual!
            char userChoice = 'x';
            while (userChoice != 'Y' && userChoice != 'N')
            {
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                PrintCentered("You Won!\n", ConsoleWidth);
                SetColorsByDefault();

                // Report the time taken to the user
                Console.WriteLine($"It only took you {(gameTimer.ElapsedMilliseconds / 1000) / 60:F0} minute(s) and {(gameTimer.ElapsedMilliseconds / 1000) % 60} second(s)");

                // Propose new game
                Console.CursorVisible = false;
                PrintCentered("Play again? (Y or N)", ConsoleWidth);
                char.TryParse(Console.ReadKey().KeyChar.ToString().ToUpper(), out userChoice);

                switch (userChoice)
                {
                    case 'Y':
                        OpenGameMenu();
                        Environment.Exit(0);
                        break;
                    case 'N':
                        Environment.Exit(0);
                        break;
                }
            }
            Console.CursorVisible = true;

        }

        /// <summary>
        /// Places the list of boats on the gameboard.
        /// </summary>
        /// <param name="boatList"></param>
        void PlaceBoatsByRandom(List<Boat> boatList)
        {
            // Local Declarations
            Random rng = new Random();

            // Sort the boat list from largest to smallest
            boatList = boatList.OrderByDescending(boat => boat.Length).ToList();

            // Assign a random direction to each boat
            foreach (Boat boat in boatList)
            {
                boat.Direction = (BoatDirection)rng.Next(0, 2);
            }

            // Go through each boat
            foreach (Boat boat in boatList)
            {
                // Local Declarations
                bool currentBoatHasBeenPlaced = false;

                // Assemble a list of the proposed coordinates (defaulted to -1)
                int baseX = -1;
                int baseY = -1;
                int endX = -1;
                int endY = -1;

                // Loop until an open area is selected for the boat
                while (!currentBoatHasBeenPlaced)
                {
                    // Make the test boolean true to pass if it's not made false later
                    currentBoatHasBeenPlaced = true;

                    // Choose new location base
                    baseX = rng.Next(0, BoardSize - boat.Length);
                    baseY = rng.Next(0, BoardSize - boat.Length);

                    // Choose new location end
                    if (boat.Direction == BoatDirection.Down)
                    {
                        endX = (baseX + boat.Length) - 1;
                        endY = baseY;
                    }
                    else
                    {
                        endX = baseX;
                        endY = (baseY + boat.Length) - 1;
                    }

                    // Loop through each proposed cell to see if it's owned by another boat
                    for (int i = baseX; i <= endX; i++)
                    {
                        for (int j = baseY; j <= endY; j++)
                        {
                            foreach (Boat checkBoat in boats)
                            {
                                foreach (Pair2D pair2D in checkBoat.CoordinatesOwned)
                                {
                                    if (pair2D.X == i && pair2D.Y == j)
                                    {
                                        currentBoatHasBeenPlaced = false;
                                    }
                                }
                            }
                        }
                    }
                }

                // Now that a proper location has been chosen, tell the boat to take ownership of those pairs
                boat.TakeOwnershipOfPairs(baseX, baseY, endX, endY);
            }
        }

        /// <summary>
        /// Takes the user input that is expected to be a letter and a number (in that order) and returns it, translated into a Pair2D. Will return null if anything else.
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns>Returns a Pair2D that represents the user's shot choice.</returns>
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

                default:
                    return null;
            }
        }

        /// <summary>
        /// Checks to see if the passed in <paramref name="xShotAt"/> and <paramref name="yShotAt"/> coordinates are owned by any of the boats in <see cref="boats"/>, and if not, switches the cell to a "missed shot".
        /// </summary>
        /// <param name="xShotAt">The x coordinate.</param>
        /// <param name="yShotAt">The y coordinate.</param>
        bool MakeAShot(int xShotAt, int yShotAt)
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
                        CheckForBoatFullyDestroyed(boat);
                        return boat.IsDestroyed;
                    }
                }
            }

            // If not, go and make that corresponding BoardCell's value = 'x'
            cells[xShotAt, yShotAt].BoardState = 'o';
            return false;

            // Local Functions
            void CheckForBoatFullyDestroyed(Boat boat)
            {
                // Local Declarations
                bool decision = true;

                // Loop through each coordinate pair the boat owns
                foreach (Pair2D pair in boat.CoordinatesOwned)
                {
                    if (cells[pair.X, pair.Y].BoardState != 'x')
                    {
                        decision = false;
                    }
                }

                boat.IsDestroyed = decision;

                if (decision)
                {
                    deadBoatCount++;
                }
            }
        }

        /// <summary>
        /// Clears the console and prints the game state with the new changes.
        /// </summary>
        void UpdateInGameVisual()
        {
            // Clear the console
            Console.Clear();

            // Print the status of the player
            SetColorsByDefault();
            Console.WriteLine();
            PrintCentered($"Boats Destroyed: {deadBoatCount}\tBoats Left: {boats.Count - deadBoatCount}\n", ConsoleWidth);
            
            // Print Partition
            for (int i = 0; i < ConsoleWidth; i++)
            {
                Console.Write("_");
            }

            Console.WriteLine();

            // Print the top area of the game board
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
        /// Go through and mark on the map where the boats are for easy grading purposes (and those who don't like challenge).
        /// </summary>
        void ForceCellsByGradingMode()
        {
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    foreach (Boat boat in boats)
                    {
                        foreach (Pair2D pair2D in boat.CoordinatesOwned)
                        {
                            if (pair2D.X == i && pair2D.Y == j)
                            {
                                cells[i, j].BoardState = 's';
                            }
                        }
                    }
                }
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
        void PlayBoatDestroyedVisualAndSound()
        {
            // Print extra line and report data and play sound
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Congrats! You destroyed a boat.");
            SetColorsByDefault();
            Console.WriteLine();
            Console.CursorVisible = false;
            Console.Write("Press any key to continue...");

            // The beeps
            Console.Beep(130, 180);
            Thread.Sleep(5);
            Console.Beep(165, 120);
            Thread.Sleep(5);
            Console.Beep(294, 1000);
            Thread.Sleep(60);
            Console.ReadKey();
            Console.CursorVisible = true;
            UpdateInGameVisual();
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
        void SetColorsByDefault()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Change the console background to <see cref="ConsoleColor.DarkBlue"/> and the foreground color to <see cref="ConsoleColor.White"/>
        /// </summary>
        void SetColorsByGrid()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Prints the message in the center of the console given the console width constant (does not print new line character by default).
        /// </summary>
        /// <param name="message">The message to be printed in the console.</param>
        /// <param name="consoleWidth">The set width of the console.</param>
        void PrintCentered(string message, int consoleWidth)
        {
            // Calculate buffer
            int buffer = (consoleWidth - message.Length) / 2;

            // Print the buffer
            for (int i = 0; i < buffer; i++)
            {
                Console.Write(" ");
            }

            // Print the message
            Console.Write(message);
        }

        /// <summary>
        /// Prints the message justified left with some buffer space given the console width constant (does not print new line character by default).
        /// </summary>
        /// <param name="message">The message to be printed in the console.</param>
        /// <param name="consoleWidth">The set width of the console.</param>
        void PrintLeftJust(string message, int consoleWidth)
        {
            // Calculate buffer
            int buffer = consoleWidth / 8;

            // Print the buffer
            for (int i = 0; i < buffer; i++)
            {
                Console.Write(" ");
            }

            // Print the message
            Console.Write(message);
        }

        /// <summary>
        /// Reset all board cells to be ' ' chars.
        /// </summary>
        void FlushBoard()
        {
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    cells[i, j].BoardState = ' ';
                }
            }
        }

        #endregion
    }
}
