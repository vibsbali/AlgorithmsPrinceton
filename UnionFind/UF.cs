namespace UnionFind
{
    public class Uf
    {
        public int[] Items { get; set; }
        public Uf(int size)
        {
            Items = new int[size];

            for (int i = 0; i < Items.Length; i++)
            {
                Items[i] = i;
            }
        }

        //This is a brute force Quadratic time performance
        public void Union(int a, int b)
        {
            int valueAtA = Items[a];
            int valueAtB = Items[b];

            for (int i = 0; i < Items.Length; i++)
            {
                if (Items[i] == valueAtA)
                {
                    Items[i] = valueAtB;
                }
            }
        }

        public bool AreConnected(int a, int b)
        {
            return Items[a] == Items[b];
        }
    }
}
