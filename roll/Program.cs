using System;
using System.Linq;

namespace roll
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #if DEBUG
            args = new[] {"1d20", "+", "3"};
            #endif

            string fullInput = string.Join(" ",args);

            Console.WriteLine(fullInput);
        }
    }
}
