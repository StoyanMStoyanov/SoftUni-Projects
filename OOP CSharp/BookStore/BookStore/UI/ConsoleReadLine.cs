using BookStore.Interfaces;

namespace BookStore.UI
{
    class ConsoleReadLine:IInputHandler
    {
        public string ReadLine()
        {
            return System.Console.ReadLine();
        }
    }
}
