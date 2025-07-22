using SnakeGame.Constants;
using SnakeGame.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Entities
{
    public class Snake
    {
        public Direction CurrDirection { get; private set; }
        public LinkedList<Cell> _body;

        public Snake(Cell head)
        {
            CurrDirection = Direction.Right;
            _body = new LinkedList<Cell>();
            _body.AddFirst(head);
            head.Status = CellType.SnakeNode;
        }

        public void ChangeDirection(Direction direction)
        {
            if (
                direction == Direction.Right && CurrDirection == Direction.Left || 
                direction == Direction.Left && CurrDirection == Direction.Right || 
                direction == Direction.Up && CurrDirection == Direction.Down || 
                direction == Direction.Down && CurrDirection == Direction.Up
                )
            {
                return;
            }
            
            CurrDirection = direction;
        }

        public void Update(Cell nextCell)
        {
            if(nextCell.Status == CellType.SnakeNode)
            {
                throw new SnakeIntersectionException(nextCell);
            }
            nextCell.Status = CellType.SnakeNode;
            _body.AddFirst(nextCell);
            _body.Last.Value.Status = CellType.Empty;
            _body.RemoveLast();
        }

        internal (int row, int col) GetPossibleNextCellPosition()
        {
            var head = _body.First.Value;
            if (CurrDirection == Direction.Left)
            {
                return (head.Row, head.Col-1);
            }
            if (CurrDirection == Direction.Right)
            {
                return (head.Row, head.Col+1);
            }
            if (CurrDirection == Direction.Up)
            {
                return (head.Row - 1, head.Col);
            }

            return (head.Row + 1, head.Col);
            
        }

        internal bool EatFood(Cell nextCell)
        {
            if(nextCell.Status == CellType.Food)
            {
                nextCell.Status = CellType.SnakeNode;
                _body.AddFirst(nextCell);
                return true;
            }
            return false;
        }
    }
}
