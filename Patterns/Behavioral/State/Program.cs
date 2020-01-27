using System;

namespace State
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var editor = new Editor();
            
            editor.Write("Soheil");
            
            editor.SetState(new UpperWrite());
            
            editor.Write("Soheil");
            
            editor.SetState(new LowerWrite());
            
            editor.Write("Soheil");

            Console.ReadKey();
        }
    }
}