using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public class Mine
    {
        public class Player
        {
            private string name;
            private int score;

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            public int Score
            {
                get { return this.score; }
                set { this.score = value; }
            }

            public Player(string name, int points)
            {
                this.Name = name;
                this.Score = points;
            }
        }

        static void Main(string[] arguments)
        {
            const int max = 35;
            string command = string.Empty;
            char[,] field = CreateGameField();
            char[,] mines = PutMines();
            int currentScore = 0;
            bool isAlive = false;
            bool isItFirstMove = true;
            bool areAllSafeRectanglesOpen = false;
            List<Player> champions = new List<Player>(6);
            int row = 0;
            int col = 0;

            do
            {
                if (isItFirstMove)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    GameField(field);
                    isItFirstMove = false;
                }

                Console.Write("Daj red i kolona : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        PrintTopScores(champions);
                        break;
                    case "restart":
                        field = CreateGameField();
                        mines = PutMines();
                        GameField(field);
                        isAlive = false;
                        isItFirstMove = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (mines[row, col] != '*')
                        {
                            if (mines[row, col] == '-')
                            {
                                MakeATurn(field, mines, row, col);
                                currentScore++;
                            }

                            if (max == currentScore)
                            {
                                areAllSafeRectanglesOpen = true;
                            }
                            else
                            {
                                GameField(field);
                            }
                        }
                        else
                        {
                            isAlive = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (!isAlive)
                {
                    GameField(mines);

                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
                        "Daj si niknejm: ", currentScore);
                    string nickname = Console.ReadLine();
                    Player currentPlayer = new Player(nickname, currentScore);

                    if (champions.Count < 5)
                    {
                        champions.Add(currentPlayer);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Score < currentPlayer.Score)
                            {
                                champions.Insert(i, currentPlayer);
                                champions.RemoveAt(champions.Count - 1);

                                break;
                            }
                        }
                    }

                    champions.Sort((Player player1, Player player2) => player2.Name.CompareTo(player1.Name));
                    champions.Sort((Player player1, Player player2) => player2.Score.CompareTo(player1.Score));
                    PrintTopScores(champions);
                    //Reset the game
                    field = CreateGameField();
                    mines = PutMines();
                    currentScore = 0;
                    isAlive = false;
                    isItFirstMove = true;
                }

                if (areAllSafeRectanglesOpen)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    GameField(mines);

                    Console.WriteLine("Daj si imeto, batka: ");
                    string name = Console.ReadLine();
                    Player player = new Player(name, currentScore);

                    champions.Add(player);
                    PrintTopScores(champions);
                    //Reset the game

                }
            }

            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void PrintTopScores(List<Player> players)
        {
            Console.WriteLine("\nTo4KI:");
            if (players.Count > 0)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii",
                        i + 1, players[i].Name, players[i].Score);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void MakeATurn(char[,] gameField,
            char[,] mines, int row, int col)
        {
            char numberOfMines = GetTheNumberOfMines(mines, row, col);
            mines[row, col] = numberOfMines;
            gameField[row, col] = numberOfMines;
        }

        private static void GameField(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PutMines()
        {
            int rows = 5;
            int cols = 10;
            char[,] gameField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int randomGeneratedNumber = random.Next(50);
                if (!mines.Contains(randomGeneratedNumber))
                {
                    mines.Add(randomGeneratedNumber);
                }
            }

            foreach (int mine in mines)
            {
                int col = (mine / cols);
                int row = (mine % cols);
                if (row == 0 && mine != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }
                gameField[col, row - 1] = '*';
            }

            return gameField;
        }

        private static void CalculateScore(char[,] gameField)
        {
            int rows = gameField.GetLength(0);
            int cols = gameField.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (gameField[i, j] != '*')
                    {
                        char numberOfBombs = GetTheNumberOfMines(gameField, i, j);
                        gameField[i, j] = numberOfBombs;
                    }
                }
            }
        }

        private static char GetTheNumberOfMines(char[,] gameField, int row, int col)
        {
            int numberOfBombs = 0;
            int rows = gameField.GetLength(0);
            int cols = gameField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (gameField[row - 1, col] == '*')
                {
                    numberOfBombs++;
                }
            }

            if (row + 1 < rows)
            {
                if (gameField[row + 1, col] == '*')
                {
                    numberOfBombs++;
                }
            }

            if (col - 1 >= 0)
            {
                if (gameField[row, col - 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if (col + 1 < cols)
            {
                if (gameField[row, col + 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (gameField[row - 1, col - 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (gameField[row - 1, col + 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (gameField[row + 1, col - 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (gameField[row + 1, col + 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            return char.Parse(numberOfBombs.ToString());
        }
    }
}
