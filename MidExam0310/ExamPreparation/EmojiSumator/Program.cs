using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EmojiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var emojiCode = Console.ReadLine().Split(":");

            int power = 0;
            var foundEmojis = new List<string>();

            var pattern = @"[\s]{1}(?<emoji>:[a-z]{4,}:)([\s,.!?]{1})";

            var matches = Regex.Matches(input, pattern);

            if (Regex.IsMatch(input, pattern))
            {

                foreach (Match match in matches)
                {
                    var emoji = match.Groups["emoji"].Value;
                    foundEmojis.Add(emoji);

                    for (int i = 1; i < emoji.Length-1; i++)
                    {
                        power += emoji[i];
                    }
                }
            }

            var givenEmoji = string.Empty;

            for (int i = 0; i < emojiCode.Length; i++)
            {
                var symbol = (char)int.Parse(emojiCode[i]);
                givenEmoji += symbol;
            }

            for (int i = 0; i < foundEmojis.Count; i++)
            {
                var currentEmoji = foundEmojis[i].Remove(0, 1);
                currentEmoji = currentEmoji.Remove(currentEmoji.Length - 1, 1);

                if (currentEmoji == givenEmoji)
                {
                    power *= 2;
                    break;
                }
            }

            if (foundEmojis.Count > 0)
            {
                Console.WriteLine($"Emojis found: {string.Join(", ", foundEmojis)}");
            }

            Console.WriteLine($"Total Emoji Power: {power}");
        }
    }
}

