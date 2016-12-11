namespace UnionFind
{
    public class UnionFindOptimized
    {
        private readonly int[] backingStore;
        public int NumberOfUnconnectedPoints { get; private set; }

        public UnionFindOptimized(int size)
        {
            //instantiate and initialize
            backingStore = new int[size];
            for (int i = 0; i < size; i++)
            {
                backingStore[i] = i;
            }

            NumberOfUnconnectedPoints = size;
        }

        public void Union(int a, int b)
        {
            var rootOfA = FindRoot(a);
            var rootOfB = FindRoot(b);

            //i.e. if a and b are not connected
            if (rootOfA != rootOfB)
            {
                backingStore[a] = rootOfB;
                NumberOfUnconnectedPoints--;
            }
        }

        private int FindRoot(int p0)
        {
            while (backingStore[p0] != p0)
            {
                p0 = backingStore[p0];
            }

            return p0;
        }

        public bool AreConnected(int p0, int p1)
        {
            return FindRoot(p0) == FindRoot(p1);
        }
    }
}
