# Snake Game

This is a classic implementation of the Snake game developed in C#. The game runs in the console and provides a simple yet engaging experience.

## Features

- **Classic Gameplay**: Control the snake to eat food and grow longer.
- **Dynamic Growth**: The snake increases in length each time it consumes food.
- **Game Over Conditions**: The game ends if the snake collides with the walls or with its own body.
- **Win Condition**: The game is won if the snake grows to fill the entire board.
- **Configurable Board**: The game board can be initialized with a custom size (minimum 3x3).

## Getting Started

Follow these instructions to get a copy of the project up and running on your local machine.

### Prerequisites

- [.NET 8.0 SDK](httpss://dotnet.microsoft.com/download/dotnet/8.0) or later.

### Installation & Running

1.  **Clone the repository:**
    ```sh
    git clone https://github.com/prashdhote92/LLD.git
    cd LLD
    ```

2.  **Build the project:**
    ```sh
    dotnet build SnakeGame/SnakeGame.sln
    ```

3.  **Run the game:**
    ```sh
    dotnet run --project SnakeGame/SnakeGame/SnakeGame.csproj
    ```
    
## Project Structure

The project is organized into the following directories:

- `SnakeGame/SnakeGame/`: The main project directory.
  - `Entities/`: Contains the core game objects:
    - `Board.cs`: Represents the game board.
    - `Snake.cs`: Represents the snake.
    - `Cell.cs`: Represents a single cell on the board.
  - `Constants/`: Contains enums for game states and directions:
    - `CellType.cs`: Defines the type of a cell (e.g., Empty, Food, Snake).
    - `Direction.cs`: Defines the possible directions for the snake.
    - `GameStatus.cs`: Defines the status of the game (e.g., NotStarted, InProgress, Won, Lost).
  - `Exceptions/`: Contains custom exceptions for game-over scenarios:
    - `SnakeIntersectionException.cs`: Thrown when the snake collides with itself.
    - `SnakeOutOfBoundaryException.cs`: Thrown when the snake hits a wall.
  - `Game.cs`: The main game engine that orchestrates the gameplay.
  - `Program.cs`: The entry point of the application, responsible for handling user input and rendering the game in the console.
