using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    class Solution 
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            var result = 0;
            var processedCharacters = new List<Char>();

            for(var i = 0 ; i < a.Length; i++)
            {
                var currentCharacter = a[i];

                if (!processedCharacters.Contains(currentCharacter))
                {
                    processedCharacters.Add(currentCharacter);
                }
                else
                {
                    currentCharacter = '-';
                }

                processedCharacters.Add(currentCharacter);
                var numberOfOccurrencesinA = a.Count(c => c == currentCharacter);

                if (currentCharacter != '-')
                {
                    if (b.Contains(currentCharacter))
                    {
                        var numberOfOccurrencesinB = b.Count(c => c == currentCharacter);

                        result += Math.Abs(numberOfOccurrencesinA - numberOfOccurrencesinB);
                    }
                    else
                    {
                        result += numberOfOccurrencesinA;
                    }
                }
            }

            for (var i = 0; i < b.Length; i++)
            {
                var currentCharacter = b[i];

                if (!processedCharacters.Contains(currentCharacter))
                {
                    processedCharacters.Add(currentCharacter);
                }
                else
                {
                    currentCharacter = '-';
                }


                if (currentCharacter != '-')
                {
                    if (!a.Contains(currentCharacter))
                    {
                        var numberOfOccurrencesInB = b.Count(c => c == currentCharacter);
                        result += numberOfOccurrencesInB;
                    }
                }
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}