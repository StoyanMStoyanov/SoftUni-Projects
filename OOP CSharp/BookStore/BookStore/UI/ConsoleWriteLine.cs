using BookStore.Interfaces;

namespace BookStore.UI
{
    class ConsoleWriteLine:IRenderer
    {
        public void WriteLine(string message, params string[] parameters)
        {
            System.Console.WriteLine(message, parameters);
        }
    }
}
