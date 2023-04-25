using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] guessed = new char[26];
            string[] words = new string[10] {"dotnet","java","python","rust","javascript","typescript","html","jquery","kotlin","swift"};
            Random rangen = new Random();
            int num = Convert.ToInt32(rangen.Next(0, 9));
            char[] word = words[num].ToCharArray();
            char[] copy = word;
            string asterix = "";
            int lives = 5;
            int count = 0;
            for(int i=0; i<word.Length;i++)
            {
                asterix = asterix + "*";
            }
            char[] testword = asterix.ToCharArray();

            char guess;

            int score = 0;
            Console.WriteLine(testword);
            
            for (int i = 0; i < 26; i++)
            {
                bool right = false;
                Console.WriteLine($"{lives} lives left");
                Console.WriteLine("Please enter a letter to guess: ");

                guess = char.Parse(Console.ReadLine());
                for(int j = 0;j<copy.Length;j++)
                {
                    if (copy[j]==guess)
                    {
                        Console.WriteLine("Your guess is correct");
                        testword[j] = guess;
                        right = true;
                        count++;
                    }
                }
                if (right != true)
                {
                    lives--;
                    Console.WriteLine("Your guess is incorrect.");
                    Console.WriteLine($"{lives} lives left");
                    score++;
                    if (lives == 0)
                    {
                        Console.WriteLine("All lives lost");
                        Console.WriteLine("Try again next time");
                        break;
                    }
                }
                if(count==copy.Length)
                {
                    Console.WriteLine("hooray you won the game!!!!!!!!!!!!");
                    break;
                }
                else
                {
                    right = false;
                }
                Console.WriteLine(testword);
            }

            Console.ReadLine();

        }
    }
}
