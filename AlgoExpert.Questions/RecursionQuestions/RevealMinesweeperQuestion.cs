using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Questions.RecursionQuestions
{
    public class RevealMinesweeperQuestion
    {
        // O (w *h) time | O (w * h) space - where w is the width of the board, and h is the height of the board
        public static string[][] RevealMinesweeper(string[][] board, int row, int column)
        {
            // Write your code here.
            if (board[row][column] == "M")
            {
                board[row][column] = "X";
                return board;
            }

            List<CellLocaltion> neighbors = GetNeighbors(board, row, column);
            int adjcentMinesCount = 0;
            foreach (var neigbor in neighbors)
            {
                if (board[neigbor.row][neigbor.column] == "M")
                {
                    adjcentMinesCount++;
                }
            }

            if (adjcentMinesCount > 0)
            {
                board[row][column] = adjcentMinesCount.ToString();
            }
            else
            {
                board[row][column] = "0";
                foreach (var neighbor in neighbors)
                {
                    if (board[neighbor.row][neighbor.column] == "H")
                    {
                        RevealMinesweeper(board, neighbor.row, neighbor.column);
                    }
                }
            }

            return board;
        }

        private static List<CellLocaltion> GetNeighbors(string[][] board, int row, int column)
        {
            int[,] directions = new int[8, 2] {
                { -1, -1 },
                { -1, 0 },
                { -1, 1 },
                { 0, -1 },
                { 0, 1 },
                { 1, -1 },
                { 1, 0 },
                { 1, 1 }
            };

            List<CellLocaltion> neighbors = new List<CellLocaltion>();
            for (int i = 0; i < directions.GetLength(0); i++)
            {
                int newRow = row + directions[i, 0];
                int newColumn = column + directions[i, 1];

                if (newRow >= 0 && newRow < board.Length && newColumn >= 0 && newColumn < board[0].Length)
                {
                    neighbors.Add(new CellLocaltion(newRow, newColumn));
                }
            }
            return neighbors;
        }

        public class CellLocaltion
        {
            public int row;
            public int column;

            public CellLocaltion(int row, int column)
            {
                this.row = row;
                this.column = column;
            }
        }
    }
}
