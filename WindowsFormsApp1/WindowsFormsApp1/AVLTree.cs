using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class AVLTree<T> : BStree<T> where T : IComparable 
    {

       
        public AVLTree()
        {
             node = null;
        }
        public AVLTree(Node<T> node)
        {
            this.node = node;
        }

        

        private void rotateRight(ref Node<T> tree)
        {

            if (tree.Left.BalanceFactor < 0)
            {
                rotateLeft(ref tree.Left);
            }
            Node<T> oldroot = tree;
            Node<T> NewRoot = tree.Left;

            oldroot.Left = NewRoot.Right;
            NewRoot.Right = oldroot;

            tree = NewRoot;
        }
        private void rotateLeft(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor > 0)
            {
                rotateRight(ref tree.Right); 
            }
            Node<T> oldroot = tree;
            Node<T> NewRoot = tree.Right;


            oldroot.Right = NewRoot.Left;
            NewRoot.Left = oldroot;

            tree = NewRoot;
        }

        public new void InsertItem(T item)
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
            tree.BalanceFactor = height(ref tree.Left) - height(ref tree.Right);

            if (tree.BalanceFactor <= -2)
            {
                rotateLeft(ref tree);
            }
            if (tree.BalanceFactor >= 2)
            {
                rotateRight(ref tree);
            }
        }

        public new void Removeitem(T item)
        { 

            RemoveItem(item, ref node);
        }

        protected new Node<T> RemoveItem(T item, ref Node<T> tree)
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
            if (tree !=null)
            {
                tree.BalanceFactor = height(ref tree.Left) - height(ref tree.Right);

                if (tree.BalanceFactor <= -2)
                {
                    rotateLeft(ref tree);
                }
                if (tree.BalanceFactor >= 2)
                {
                    rotateRight(ref tree);
                }
            }
           return tree;

        }


    }
}
