using System;
using System.Collections.Generic;
using BookStore.UI;
using BookStore.Engine;

namespace BookStore
{
    class BookStoreMain
    {
        static void Main()
        {
            ConsoleWriteLine renderer = new ConsoleWriteLine();
            ConsoleReadLine inputHandler = new ConsoleReadLine();            
            BookStoreEngine engine = new BookStoreEngine(renderer, inputHandler);
            //string filePath = "..\\..\\Text.txt";
            //FileRenderer fr = new FileRenderer(filePath);
            //BookStoreEngine engine = new BookStoreEngine(fr, inputHandler);

            engine.Run();
        }
    }
}
