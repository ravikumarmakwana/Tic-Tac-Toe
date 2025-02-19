# Tic-Tac-Toe Game

## Overview
This is an efficient implementation of a Tic-Tac-Toe game in C#. The class `TicTacToe` supports checking the game state after each move in **O(1) time complexity** using a **counter-based approach**.

## Features
- Supports dynamic board sizes (`n x n`).
- Uses counters to track row, column, and diagonal moves.
- Determines the winner in constant time.
- Optimized for performance without storing the entire board.

## How It Works
- Each move updates the row, column, and diagonals for the respective player.
- If any of these counters reach `n`, the player wins.
- The function returns:
  - `0` if the game continues.
  - `1` if Player 1 wins.
  - `2` if Player 2 wins.

## Time & Space Complexity
- **Time Complexity**: `O(1)` per move.
- **Space Complexity**: `O(n)`.
