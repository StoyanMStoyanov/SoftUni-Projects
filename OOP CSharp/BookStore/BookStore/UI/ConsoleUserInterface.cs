using System;

namespace BookStore.UI
{
    class ConsoleUserInterface
    {
        string ReadLine()
        {
            return Console.ReadLine();
        }

        void WriteLine(string message, params string[] paraeters)
        {
            Console.WriteLine(message, paraeters);
        }
    }
}
