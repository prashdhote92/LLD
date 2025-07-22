using SnakeGame.Entities;

namespace SnakeGame.Exceptions
{
    [Serializable]
    internal class SnakeIntersectionException : Exception
    {
        private Cell nextCell;

        public SnakeIntersectionException()
        {
        }

        public SnakeIntersectionException(Cell nextCell)
        {
            this.nextCell = nextCell;
        }

        public SnakeIntersectionException(string? message) : base(message)
        {
        }

        public SnakeIntersectionException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}