using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class BinTree<T> where T : IComparable
    {

        protected Node<T> node;
        public BinTree()  //creates an empty tree
        {
            node = null;
        }
        public BinTree(Node<T> node)  //creates a tree with node as the root
        {
            this.node = node;
        }

       
        private void inOrder(ref string buffer)
        {
            inorder(node, ref buffer);
        }

        public void Postorder(ref string buffer)
        {
            postorder(node, ref buffer);
        }
        private void postorder(Node<T> root, ref string buffer)
        {
            if (root != null)
            {
                buffer += root.Data.ToString() + ", ";
                postorder(root.Left, ref buffer);
                postorder(root.Right, ref buffer);

            }

        }

        public void Preorder(ref string buffer)
        {
            preorder(node, ref buffer);
        }
        private void preorder(Node<T> root, ref string buffer)
        {
            if (root != null)
            {
                buffer += root.Data.ToString() + ",";

                preorder(root.Left, ref buffer);
                preorder(root.Right, ref buffer);
            }

        }
        public void Inorder(ref String buffer)
        {
            inorder(node, ref buffer);
        }

        public void inorder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                inorder(tree.Left, ref buffer);

                buffer += tree.Data.ToString() + ",";
                inorder(tree.Right, ref buffer);
            }

        }
        public void Copy(BinTree<T> tree2)
        {
            copy(ref node, tree2.node);
        }
        private void copy(ref Node<T> tree, Node<T> tree2)
        {
            Node<int> Copy = new Node<int>(0);

            if (tree.Left != null)
            {
                copy(ref tree.Left, tree2.Left);
            }
            else if (tree.Right != null)
            {
                copy(ref tree.Left, tree2.Left);
            }
        }

       

    }
}


