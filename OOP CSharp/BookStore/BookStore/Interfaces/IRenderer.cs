namespace BookStore.Interfaces
{
    interface IRenderer
    {
        void WriteLine(string message, params string[] parameters);
    }
}
