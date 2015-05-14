using System;

class BasketBattle
{
    static void Main()
    {
        string nameFirstPlayer = Console.ReadLine();
        string nameSecondPlayer;
        if (nameFirstPlayer == "Simeon") nameSecondPlayer = "Nakov";
        else nameSecondPlayer = "Simeon";
       
        int rounds = int.Parse(Console.ReadLine());
        int firstPlayer = 0;
        int secondPlayer = 0;
        int score = 0;
        bool winner = true;

        for (int round = 1; round <= rounds; round++)
        {
            score = int.Parse(Console.ReadLine());
            if (Console.ReadLine() == "success")
            {
                if (round % 2 != 0)
                {
                    firstPlayer += score;
                    if (firstPlayer > 500) firstPlayer -= score;
                }
                else
                {
                    secondPlayer += score;
                    if (secondPlayer > 500) secondPlayer -= score; 
                }
            }
            if (firstPlayer == 500 || secondPlayer == 500)
            {
                winner = false;
                Console.WriteLine("{0}\n{1}\n{2}",
                    firstPlayer > secondPlayer ? nameFirstPlayer : "Nakov", 
                    round, 
                    firstPlayer > secondPlayer ? secondPlayer : firstPlayer);
                break;
            }
            score = int.Parse(Console.ReadLine());
            if (Console.ReadLine() == "success")
            {
                if (round % 2 != 0)
                {
                    secondPlayer += score;
                    if (secondPlayer > 500) secondPlayer -= score;
                }
                else
                {
                    firstPlayer += score;
                    if (firstPlayer > 500) firstPlayer -= score;
                }
            }
            if (firstPlayer == 500 || secondPlayer == 500)
            {
                winner = false;
                Console.WriteLine("{0}\n{1}\n{2}",
                    firstPlayer > secondPlayer ? nameFirstPlayer : nameSecondPlayer,
                    round,
                    firstPlayer > secondPlayer ? secondPlayer : firstPlayer);
                break;
            }
        }

        if (winner && firstPlayer == secondPlayer)
            Console.WriteLine("DRAW\n{0}", secondPlayer);

        if(winner && firstPlayer != secondPlayer )
            Console.WriteLine("{0}\n{1}",
                    firstPlayer > secondPlayer ? nameFirstPlayer : nameSecondPlayer,
                    Math.Abs(firstPlayer - secondPlayer));
    }
}
