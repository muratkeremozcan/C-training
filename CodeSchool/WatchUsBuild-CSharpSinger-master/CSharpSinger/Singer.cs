using System;

namespace CSharpSinger
{
    public static class Singer  // by making a class or method static , we don't have to instantiate Singer, c
    {                           // can just do singer.WriteLine and it'll work ... as opposed to new Singer assingn to variable & variable.method
        public static void WriteLine(string line)
        {
            var results = line.Split(':');
            WriteLine(results[0], int.Parse(results[1]));
        }

        public static void WriteLine(string line, int time)
        {
            int speed = time/line.Length;  
            foreach(var letter in line.ToCharArray())
            {
                Console.Write(letter);  // Console.Write will keep adding to the same line
                System.Threading.Thread.Sleep(speed); // new method
            }
            Console.WriteLine("");
        }
    }
}
