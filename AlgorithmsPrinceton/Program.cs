using System;
using UnionFind;

namespace AlgorithmsPrinceton
{
    class Program
    {
        static void Main()
        {
            var uf = new UnionFindOptimized(10);

            uf.Union(4, 3);
            uf.Union(3, 8);
            uf.Union(6, 5);
            uf.Union(9, 4);
            uf.Union(2, 1);


            Console.WriteLine(uf.AreConnected(0, 7));
            Console.WriteLine(uf.AreConnected(8, 9));

            uf.Union(5, 0);
            uf.Union(7, 2);
            uf.Union(6, 1);
            uf.Union(1, 0);
            Console.WriteLine(uf.AreConnected(0, 7));

            Console.WriteLine(uf.NumberOfUnconnectedPoints);
        }
    }
}
