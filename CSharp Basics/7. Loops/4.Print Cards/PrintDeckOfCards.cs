using System;

class PrintDeckOfCards
{    
    static void Main()
    {        
        string cards = "2,3,4,5,6,7,8,9,10,J,D,K,A";
        string[] cardsStr = cards.Split(',');
       
        for (int index = 0; index < cardsStr.Length; index++)
        {
            for (int suits = 0; suits < 4; suits++)
            {
                switch (suits)
                {
                    case 0:
                        Console.Write("{0,3}{1} ", cardsStr[index], char.Parse("\u2663"), " ");
                        break;
                    case 1:
                        Console.Write("{0,3}{1}", cardsStr[index], char.Parse("\u2666") + " ");
                        break;
                    case 2:
                        Console.Write("{0,3}{1}", cardsStr[index], char.Parse("\u2665") + " ");
                        break;
                    case 3:
                        Console.Write("{0,3}{1}", cardsStr[index], char.Parse("\u2660"));
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}
