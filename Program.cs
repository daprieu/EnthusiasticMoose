
using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();
    // Let the moose speak!
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    // As a question
   Questions();
} 
void MooseSays(string message)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

// Ask a question
bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

void Questions()
{
    bool isTrue = MooseAsks("Is Canada real?");
    MooseSays(isTrue ? "Really? It seems very unlikely." : "I  K N E W  I T !!!");
    
    bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
    MooseSays(isEnthusiastic ? "Yay!" : "You should try it!");
    
    bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
    MooseSays(doesLoveCSharp ? "Good job sucking up to your instructor!" : "You will...oh, yes, you will...");
  
    bool wantsSecret = MooseAsks("Do you want to know a secret?");
    MooseSays(wantsSecret ? "ME TOO!!!! I love secrets...tell me one!" : "Oh, no...secrets are the best, I love to share them!");
}


