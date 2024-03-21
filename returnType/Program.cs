using Microsoft.VisualBasic;

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}





void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = random.Next(1, 5);
        var roll = random.Next(1, 6);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    string? input = Console.ReadLine();
    if (input != null)
    {
        if (input.ToLower() == "y")
        {
            return true;
        }
        else if (input.ToLower() == "n")
        {
            return false;
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }
}

string WinOrLose(int goal, int toss)
{
    if (toss > goal)
    {
        return "You win!";
    }
    else
    {
        return "You lose!";
    }
}
