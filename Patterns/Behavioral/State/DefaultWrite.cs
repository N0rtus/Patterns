using System;

namespace State
{
    public class DefaultWrite : IWritingState
    {
        public void Write(string words)
        {
            Console.WriteLine(words);
        }
    }
}