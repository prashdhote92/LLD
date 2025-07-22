using SnakeGame.Constants;
using System;
using System.Drawing;

namespace SnakeGame.Entities
{
    public class Board
    {
        private readonly Cell[,] _board;
        private readonly int _rows;
        private readonly int _cols;
        private Cell _food;

        public Board(int rows, int cols)
        {
            _board = new Cell[rows, cols];
            _rows = rows;
            _cols = cols;
            InitializeBoad();
        }

        private void InitializeBoad()
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    _board[i, j] = new Cell(i, j);
                }
            }
            var emptyCell = GetNextEmptyCell();
            emptyCell.Status = CellType.Food;
            _food = emptyCell;

        }

        public Cell GetMidCell()
        {
            return _board[_rows >> 1, _cols >> 1];
        }

        public Cell? GetCell(int row, int col)
        {
            if (row < 0 || row >= _rows || col < 0 || col >= _cols)
            {
                return null;
            }
            return _board[row, col];
        }

        public Cell? EatAndGenerateNextFood()
        {
            if (_food == null) return null;

            _food.Status = CellType.SnakeNode;

            _food = GetNextEmptyCell();
            if (_food == null) return null;

            _food.Status = CellType.Food;
            return _food;
        }

        private Cell GetNextEmptyCell()
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    if (_board[i, j].Status == CellType.Empty) return _board[i, j];
                }
            }

            return null;
        }


        public void Log()
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    var status = _board[i, j].Status;

                    if (status == CellType.SnakeNode) { Console.Write("S "); }
                    if (status == CellType.Empty) { Console.Write("E "); }
                    if (status == CellType.Food) { Console.Write("F "); }

                }
                Console.WriteLine();
            }
            Console.WriteLine("###");


        }
    }
}