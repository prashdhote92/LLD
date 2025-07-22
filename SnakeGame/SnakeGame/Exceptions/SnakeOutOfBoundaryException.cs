namespace SnakeGame.Exceptions
{
    [Serializable]
    internal class SnakeOutOfBoundaryException : Exception
    {
        public SnakeOutOfBoundaryException()
        {
        }

        public SnakeOutOfBoundaryException(string? message) : base(message)
        {
        }

        public SnakeOutOfBoundaryException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}