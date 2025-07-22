namespace SnakeGame.Exceptions
{
    [Serializable]
    internal class GameNotStartedException : Exception
    {
        public GameNotStartedException()
        {
        }

        public GameNotStartedException(string? message) : base(message)
        {
        }

        public GameNotStartedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}