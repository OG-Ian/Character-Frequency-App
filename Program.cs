using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterFrequencyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Character Frequency Counter ===\n");

            while (true)
            {
                Console.Write("Enter a string (or type 0 to exit): ");
                string inputRaw = Console.ReadLine();
                string input = (inputRaw ?? "").Trim();

                if (input == "0")
                {
                    Console.WriteLine("\nThank you for using the Character Frequency Counter. Goodbye!");
                    System.Threading.Thread.Sleep(2000); // Pause for 2 seconds
                    break;
                }


                if (input == "")
                {
                    Console.WriteLine("Input was empty. Please enter a valid string.\n");
                    continue;
                }

                var frequencies = CountCharacterFrequencies(input);

                Console.WriteLine("\nThe frequency of the characters are :\n");

                foreach (var pair in frequencies.OrderBy(f => f.Key))
                {
                    Console.WriteLine($"Character '{pair.Key}': {pair.Value} time{(pair.Value > 1 ? "s" : "")}");
                }

                Console.WriteLine(); // blank line before next prompt
            }
        }

        static Dictionary<char, int> CountCharacterFrequencies(string text)
        {
            var frequencyMap = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (frequencyMap.ContainsKey(c))
                {
                    frequencyMap[c]++;
                }
                else
                {
                    frequencyMap[c] = 1;
                }
            }

            return frequencyMap;

        }
    }
}
