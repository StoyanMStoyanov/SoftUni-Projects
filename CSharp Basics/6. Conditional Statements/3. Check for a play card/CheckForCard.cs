using System;

class CheckForCard
{
    static void Main()
    {
        Console.Write("Enter sign for a play card: ");
        string card = Console.ReadLine();
        int intCardParse = 0;
        char charCardParse;
        bool isPlayCard = false;
        if (int.TryParse(card, out intCardParse))
        {
            if (intCardParse > 1 && intCardParse <= 10) isPlayCard = true;
        }
        else if (char.TryParse(card, out charCardParse))
        {
            if (charCardParse == 'J' || charCardParse == 'Q' || charCardParse == 'K' || charCardParse == 'A') 
                isPlayCard = true;
        }
        Console.WriteLine("{0}", isPlayCard ? "Yes" : "No");
    }
}
