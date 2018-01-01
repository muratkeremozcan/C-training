using System;
using System.IO; // to read a file 

namespace CSharpSinger
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = { "allthistime", "codemonkey", "futuresoon" };
            Console.WriteLine("Welcome to Singer!");
            
            while (true)
            {
                Console.WriteLine("Please choose the song that you'd like sung!");
                Console.WriteLine("1 for Jonathan Coulton's 'All This Time'");
                Console.WriteLine("2 for 'The End Of The World'");
                Console.WriteLine("3 for 'It's A Small World'");
                Console.WriteLine("Enter the track number of the song you'd like or 'Quit'");
                var response = Console.ReadLine();

                if (response.ToLower() == "quit") // new method
                    break;

                var song = 0; // variable to contain 'out song'
                if(!int.TryParse(response, out song)) // try to parse the first argument, if successful, populate the 2nd argument
                {
                    Console.WriteLine("Invalid response, try again.");
                    continue; // inside a whileloop, stop execution of code and start loop from beginning
                }
                else
                    song--; //Arrays count from zero, people don't

                // set the directory to something for yourself
                var fileName = songs[song] + ".txt";

                if (!File.Exists(fileName)) // new condition type, if file does NOT exist
                {
                    Console.WriteLine("File not found, try again");
                    continue; // new keyword
                }

                Console.WriteLine("===============================");
                var lines = File.ReadAllLines(fileName); // new method, gives an array of strings for the file
                foreach (var line in lines)
                {
                    Singer.WriteLine(line);
                }
                Console.WriteLine("===============================");
            }
        }
    }
}