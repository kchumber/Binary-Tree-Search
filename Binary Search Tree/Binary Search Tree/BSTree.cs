using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class BSTree<T> : BinTree<T> where T : IComparable
    { // root declared as protected in Parent Class - BinTree
        public BSTree()
        {
            root = null;
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = new Node<T>(item);
            }

            else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);
            }

            else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }
        }

        public int Height()
        // Return the max level of the tree
        {
            return height(ref this.root);
        }

        private int height(ref Node<T> tree)
        {
            if (tree == null)
            {
                return 0;
            }

            else if (tree.Left == null && tree.Right == null)
            {
                return 0;
            }

            else
            {
                return 1 + max(height(ref tree.Left), height(ref tree.Right));
            }
        }

        public int max(int x, int y)
        {
            if (x.CompareTo(y) > 0)
            {
                return x;
            }

            else
            {
                return y;
            }
        }

        public Boolean Contains(T item)
        // Return true if the item is contained is in the BSTree, false otherwise
        {
            return contains(ref this.root, item);
        }

        private Boolean contains(ref Node<T> tree, T item)
        {
            if (tree == null)
            {
                return false;
            }

            else if (tree.Data.Equals(item))
            {
                return true;
            }

            else if (item.CompareTo(tree.Data) < 0)
            {
                return contains(ref tree.Left, item);
            }

            else
            {
                return contains(ref tree.Right, item);
            }
        }

        public void RemoveItem(T item)
        {
            if (Contains(item) == true)
            {
                removeItem(ref this.root, item);
            }

            else
            {
                Console.WriteLine("{0} not found", item);
            }
        }

        private void removeItem(ref Node<T> tree, T item)
        {
            if (tree != null)
            {
                if (item.CompareTo(tree.Data) < 0)
                {
                    removeItem(ref tree.Left, item);
                }

                else if (item.CompareTo(tree.Data) > 0)
                {
                    removeItem(ref tree.Right, item);
                }

                else
                {
                    if (tree.Left == null && tree.Right == null) // no children
                    {
                        tree = null;
                    }

                    else if (tree.Left != null && tree.Right == null) // left child only
                    {
                        tree = tree.Left;
                    }

                    else if (tree.Left == null && tree.Right != null) // right child only
                    {
                        tree = tree.Right;
                    }

                    else // 2 children
                    {
                        if (tree.Right.Left == null)
                        {
                            tree.Right.Left = tree.Left;
                            tree = tree.Right;
                        }

                        else
                        {
                            Node<T> x = tree.Right;
                            Node<T> y = tree.Right;

                            while (y.Left.Left != null)
                            {
                                y = y.Left;
                            }

                            x = x.Left;
                            x.Left = y.Right;
                            y.Left = tree.Left;
                            y.Right = tree.Right;
                            tree = y;
                        }
                    }
                }
            }
        }
    }
}
