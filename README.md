# Rock, Paper, Scissors Game 💎📃✂

## Project Description

This project implements a console-based Rock, Paper, Scissors game where a player competes against an AI opponent. The game allows players to choose their moves and determines the winner based on the classic rules of Rock beats Scissors, Scissors beats Paper, and Paper beats Rock.

## Features

- **Single-player mode:** Player vs AI.
- **Game logic:** Determines round winners based on move comparisons.
- **Score tracking:** Tracks scores for both player and AI.
- **End game condition:** Game ends when either player reaches 3 points.

## Setup Instructions

1. **Clone the repository**

   ```bash
   git clone https://github.com/Loiy2002-SW/rock-paper-scissors.git

2. **Clone the repository**

   ```bash
   cd rock-paper-scissors

3. **Build and run the project**

	* Open the solution in Visual Studio.
	* Build the solution (Ctrl+Shift+B).
	* Run the project (F5 or Ctrl+F5).

4. **Play the Game**

	* Follow the on-screen instructions to play the game.
	* Enter your move (1 for Rock, 2 for Paper, 3 for Scissors) when prompted.
	* The AI opponent will make its move randomly.
	* The game will display the round result and update the scores until one player reaches 3 points.

## File Structure

		RPSGame/
		│
		├── Program.cs         # Main entry point of the application
		├── RPSGame.cs         # RPSGame class managing game logic
		├── Player.cs          # Player class representing a game player
		└── (other files)      # Additional project files

		Tests/
		│
		└── RPSGameTests.cs    # Xunit test cases for RPSGame class

		README.md              # Project documentation file



## Technologies Used
 * C# programming language
 * .NET Framework/.NET Core (depending on your project setup)
 * Xunit for unit testing
	 

## Notes
* Ensure you have .NET installed on your machine to build and run the project.
* Modify the game rules or add additional features as per your requirements.