using System;

namespace SymbolTables
{
    /// <summary>
    /// This is a modified version of Binary Search Tree
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class BinarySearchTree<TKey, TValue> where TKey : IComparable<TKey>
    {
        class Node<TInnerKey, TInnerValue> where TInnerKey : IComparable<TInnerKey>
        {
            public TInnerKey Key { get;  }
            public TInnerValue Value { get; private set; }

            public Node(TInnerKey key,TInnerValue value)
            {
                Key = key;
                Value = value;
            }

            public Node<TInnerKey, TInnerValue> Left { get; set; }
            public Node<TInnerKey, TInnerValue> Right { get; set; }

            public void UpdateValue(TInnerValue value)
            {
                Value = value;
            }
        }

        private Node<TKey, TValue> Root { get; set; }

        public TValue Get(TKey key)
        {
            var node = Root;
            while (node != null)
            {
                if (node.Key.CompareTo(key) == 0)
                {
                    return node.Value;
                }

                if (node.Key.CompareTo(key) > 0)
                {
                    node = node.Left;
                }
                else
                {
                    node = node.Right;
                }
            }

            return default(TValue);
        }

        public void Add(TKey key, TValue value)
        {
            if (key == null || value == null)
            {
                throw new InvalidOperationException("Invalid Argument");
            }

            if (Root == null)
            {
                Root = new Node<TKey, TValue>(key, value);
            }
            else
            {
                var node = Root;
                while (true)
                {
                    if (node.Key.CompareTo(key) >= 1)
                    {
                        if (node.Left == null)
                        {
                            node.Left = new Node<TKey, TValue>(key, value);
                            break;
                        }
                        node = node.Left;
                    }
                    else if (node.Key.CompareTo(key) == 0)
                    {
                        node.UpdateValue(value);
                        return;
                    }
                    else 
                    {
                        if (node.Right == null)
                        {
                            node.Right = new Node<TKey, TValue>(key, value);
                            break;
                        }
                        node = node.Right;
                    }
                }
            }
            
            Count++;
        }

        public void GetInOrderData()
        {
            InOrder(Root);
        }

        private void InOrder(Node<TKey, TValue> root)
        {
            if (root != null)
            {
                InOrder(root.Left);
                Console.WriteLine(root.Value);
                InOrder(root.Right);
            }
        }

        public void GetPreOrderData()
        {
            PreOrder(Root);
        }

        private void PreOrder(Node<TKey, TValue> root)
        {
            if (root != null)
            {
                Console.WriteLine(root.Value);
                PreOrder(root.Left);
                PreOrder(root.Right);
            }
        }

        public void GetPostOrderData()
        {
            Postorder(Root);
        }

        private void Postorder(Node<TKey, TValue> root)
        {
            if (root != null)
            {
                Postorder(root.Left);
                Postorder(root.Right);
                Console.WriteLine(root.Value);
            }
        }


        public int Count { get; private set; }
    }
}
