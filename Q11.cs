using System;

class Program
{
    static int highscore = 0;
    static string highscorePlayer = "";

    static void Main()
    {
        highscore = 1000;
        highscorePlayer = "John";
        CheckAndUpdateHighscore(1200, "Alice");
        CheckAndUpdateHighscore(800, "Bob");
        CheckAndUpdateHighscore(1500, "Carol");
    }

    static void CheckAndUpdateHighscore(int score, string playerName)
    {
        if (score > highscore)
        {
            highscore = score;
            highscorePlayer = playerName;
            Console.WriteLine("New highscore is " + score);
            Console.WriteLine("New highscore holder is " + playerName);
        }
        else
        {
            Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer);
        }
    }
}



//Output:
// New highscore is 1200
// New highscore holder is Alice
// The old highscore of 1200 could not be broken and is still held by Alice
// New highscore is 1500
// New highscore holder is Carol
