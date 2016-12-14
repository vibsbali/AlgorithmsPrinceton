using System;
using StringSearchingAlgorithms;


namespace AlgorithmsPrinceton
{
    class Program
    {
        static void Main()
        {
            var stringToSearch = "Hello";

            var originalString = "that can He llo no tfounHeHeHelhellod";

            var result = new BoyerMooreHorspool().Contains(originalString, stringToSearch);

            Console.WriteLine(result);
        }
    }
}
