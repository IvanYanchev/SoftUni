namespace BookStore.Interfaces
{
    using System;

    public interface IRenderer
    {
        void WriteLine(string message, params string[] parameters);
    }
}
