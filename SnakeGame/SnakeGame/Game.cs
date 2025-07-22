using SnakeGame.Constants;
using SnakeGame.Entities;
using SnakeGame.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Entities
{
    internal class Game
    {
        public Board Board { get; set; }
        public Snake Snake { get; set; }

        public GameStatus GameStatus { get; set; } = GameStatus.New;

        public int Score { get; set; }

        public Game(int rows, int cols) 
        {
            Board = new Board(rows, cols);
            Snake = new Snake(Board.GetMidCell());
        }

        public void Start()
        {
            Score = 0;
            GameStatus = GameStatus.Started;
        }

        public void ChangeSnakeDirection(Direction direction)
        {
            if(GameStatus != GameStatus.Started)
            {
                throw new GameNotStartedException();
            }

            Snake.ChangeDirection(direction);
        }

        public void Update()
        {
            if(GameStatus != GameStatus.Started) { throw new GameNotStartedException(); }

            var (row, col) = Snake.GetPossibleNextCellPosition();
            var nextCell = Board.GetCell(row, col);
            if(nextCell == null)
            {
                throw new SnakeOutOfBoundaryException();
            }

            if(nextCell.Status == CellType.Food)
            {
                Snake.EatFood(nextCell);
                Score++;
                var foodCell = Board.EatAndGenerateNextFood();
                if (foodCell == null)
                {
                    GameStatus = GameStatus.Win;
                }
            }
            else
            {
                Snake.Update(nextCell);
            }
        }


    }
}
