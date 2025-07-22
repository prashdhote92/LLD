using SnakeGame.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Entities
{
    public class Cell
    {

        public Cell(int row, int col)
        {
            Row = row;
            Col = col;
            Status = CellType.Empty;
        }

        public CellType Status { get; internal set; }
        public int Row { get; }
        public int Col { get; }
    }
}
