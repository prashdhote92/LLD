// See https://aka.ms/new-console-template for more information
using SnakeGame;
using SnakeGame.Constants;
using SnakeGame.Entities;

Console.WriteLine("Hello, World!");

var game = new Game(3, 3);

game.Start();
game.Board.Log();

game.Update();
game.Board.Log();

game.ChangeSnakeDirection(Direction.Up);
game.Update();
game.Board.Log();

game.ChangeSnakeDirection(Direction.Left);
game.Update();
game.Board.Log();
game.Update();
game.Board.Log();
game.ChangeSnakeDirection(Direction.Down);
game.Update();
game.Board.Log();
game.Update();
game.Board.Log();
game.Update();
game.Board.Log();
game.Update();
game.ChangeSnakeDirection(Direction.Left);


game.Board.Log();
