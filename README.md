# Number Guessing Game

This is a simple console application called "Number Guessing Game" implemented in C#. The program generates a random number between 1 and 99, and the user has 6 attempts to guess the correct number.

## Instructions

1. Run the program.
2. The program will display a welcome message and provide information about the game.
3. Enter your guess for the random number when prompted.
4. If your guess matches the random number, the program will display a congratulatory message and end.
5. If your guess is incorrect, the program will provide a hint to help you narrow down your next guess.
6. Repeat steps 3-5 until you have used all your attempts or have guessed the correct number.
7. If you use all your attempts without guessing the correct number, the program will reveal the correct number and end.
8. The game is over, and you can press Enter to exit the program.

## Requirements

- .NET Framework (compatible with the version used in the code)

## How it Works

- The program uses the `Random` class to generate a random number between 1 and 99.
- It initializes the `attempts` counter to 0 and sets the maximum number of attempts to 6.
- The program prompts the user to enter their guess using the `Console` class.
- If the user's guess matches the random number, a congratulatory message is displayed, and the program ends.
- If the user's guess is incorrect, the program provides a hint indicating whether the actual number is higher or lower.
- The loop continues until the user has used all their attempts or has guessed the correct number.
- If the user has used all their attempts without guessing correctly, the correct number is revealed, and the game ends.

Feel free to play the Number Guessing Game and try to guess the random number within the given attempts! Have fun!
