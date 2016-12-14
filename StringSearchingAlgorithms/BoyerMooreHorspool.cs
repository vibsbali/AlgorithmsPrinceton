using System;
using System.Collections.Generic;

namespace StringSearchingAlgorithms
{
    public class BoyerMooreHorspool
    {
        public static Dictionary<char, int> GetBadMatchTable(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Invalid input string");
            }

            var table = new Dictionary<char, int>();
            var lengthOfInput = input.Length;
            
            for (int i = 0; i < lengthOfInput-1; i++)
            {
                if (table.ContainsKey(input[i]))
                {
                    table[input[i]] = lengthOfInput - i - 1;
                }
                else
                {
                    table.Add(input[i], lengthOfInput - i - 1);
                }

            }

            return table;
        }


        public bool Contains(string stringToSearchWithin, string stringToSearch)
        {
            var badMatchTable = GetBadMatchTable(stringToSearch);
            var index = stringToSearch.Length - 1;

            while (index < stringToSearchWithin.Length)
            {
                var lengthOfStringToSearch = stringToSearch.Length - 1;

                while (lengthOfStringToSearch >= 0)
                {
                    if (stringToSearchWithin[index] == stringToSearch[lengthOfStringToSearch])
                    {
                        index--;
                        lengthOfStringToSearch--;
                    }
                    else
                    {
                        break;
                    }

                    //check if all the values has been matched
                    if (lengthOfStringToSearch == -1)
                    {
                        return true;
                    }
                }

                //check if the value on which bad match occurred exists in bad match table
                var skipNumber = stringToSearch.Length;
                if (badMatchTable.ContainsKey(stringToSearchWithin[index]))
                {
                    skipNumber = badMatchTable[stringToSearchWithin[index]];
                }

                index = index + skipNumber;
            }

            return false;
        }
    }


}
