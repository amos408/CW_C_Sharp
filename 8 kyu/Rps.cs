//Rock Paper Scissors!

//Let's play! You have to return which player won! In case of a draw return Draw!.

//Examples(Input1, Input2 --> Output):

//"scissors", "paper"-- > "Player 1 won!"
//"scissors", "rock"-- > "Player 2 won!"
//"paper", "paper"-- > "Draw!"

//rockpaperscissors

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
    public string Rps(string p1, string p2)
    {
        return p1 == p2 ? "Draw!" : $"Player {(new[] { 3, -1, -2 }.Contains(p1[0] - p2[0]) ? 1 : 2)} won!";
    }
}
