using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class BStree<T> :BinTree<T> where T : IComparable
    { 

        public BStree()
        {
            node = null;
        }

        public BStree(Node<T> node)
        {
            this.node = node;
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref node);
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
        {
            return height(ref node);
        }

        protected int height(ref Node<T> tree)
        {
            if (tree == null)
            {
                return 0;
            }
            else
            {
                return (1 + Math.Max(height(ref tree.Left), height(ref tree.Right)));
            }
        }


        public Boolean Contains(T item)
        {
            return Contains(item, ref node);
        }

        public Boolean Contains(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                return false;
            }
            else if (item.CompareTo(tree.Data) == 0)
            {
                return true;
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                return (Contains(item, ref tree.Left));
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                return Contains(item, ref tree.Right);
            }
            else
            {
                return false;
            }

        }

        public void Removeitem(T item)
        {
            RemoveItem(item, ref node);
        }

        protected  Node<T> RemoveItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                return null;
            }
            if (tree != null)
            {     //finding the node 
                if (item.CompareTo(tree.Data) < 0)
                {
                    RemoveItem(item, ref tree.Left); //move left
                }
                else if (item.CompareTo(tree.Data) > 0)
                {
                    RemoveItem(item, ref tree.Right); //move right
                }
                else
                {
                    if (tree.Left == null && tree.Right == null) //no childern. Leaf
                    {
                        tree = null; //set tree to null eith no childern
                    }
                    else if (tree.Left == null) //one right child
                    {
                        tree = tree.Right;
                    }
                    else if (tree.Right == null) //one child 
                    {
                        tree = tree.Left;
                    }
                    else
                    {
                        Node<T> min = MinItem(ref tree.Right);
                        tree.Data = min.Data;
                        tree.Right = RemoveItem(tree.Data, ref min);
                    }

                }
            }
            return tree;

        }
        public Node<T> MinItem(ref Node<T> tree)  
        {
            Node<T> TempNode = tree;
            if (TempNode.Left == null)
            {
                return TempNode;
            }
             else
             {
              return MinItem( ref TempNode.Left);
             }
        }

    }
}
