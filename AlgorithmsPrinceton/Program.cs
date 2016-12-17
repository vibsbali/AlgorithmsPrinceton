using System;
using System.Collections.Generic;
using SymbolTables;
using System.Linq;

namespace AlgorithmsPrinceton
{
    class Program
    {
        static void Main()
        {
            var st = new BinarySearchTree<string, int>();

            st.Add("S", 0);
            st.Add("E", 1);
            st.Add("A", 2);
            st.Add("R", 3);
            st.Add("C", 4);
            st.Add("H", 5);
            st.Add("E", 6);
            st.Add("X", 7);
            st.Add("A", 8);
            st.Add("M", 9);
            st.Add("P", 10);
            st.Add("L", 11);
            st.Add("E", 12);

            Console.WriteLine(st.Get("E"));
        }
    }
}
