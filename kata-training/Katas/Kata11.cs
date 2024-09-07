/*

Rock Paper Scissors

Let's play! You have to return which player won! In case of a draw return Draw!.

Examples(Input1, Input2 --> Output):

"scissors", "paper" --> "Player 1 won!"
"scissors", "rock" --> "Player 2 won!"
"paper", "paper" --> "Draw!"

*/

namespace kata_training.Katas;

using System;
using System.Collections.Generic;

public class Kata11
{
	public string Rps(string p1, string p2)
  {
    if (p1 == p2)
    {
      return "Draw!";
    }
    string output = "";
    return output = p1 switch
    {
        "scissors" => (p2 == "paper") ? "Player 1 won!" : "Player 2 won!",
        "paper" => (p2 == "rock") ? "Player 1 won!" : "Player 2 won!",
        "rock" => (p2 == "scissors") ? "Player 1 won!" : "Player 2 won!",
        _ => "default"
    };
  }
}