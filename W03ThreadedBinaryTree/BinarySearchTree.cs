using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03ThreadedBinaryTree
{
    class BinarySearchTree
    {
        private NodeBT root;

        
        public void insert(int value)
        {
            insert(ref root, value);
        }


        private void insert(ref NodeBT root, int value)
        {
            var newnode = new NodeBT(value);
            if (root == null) root = newnode;            
            else
            {
                if (value < root.value) insert(ref root.left, value);
                else insert(ref root.right, value);                
            }
        }


        private void insert2(ref NodeBT root, int value)
        {
            var newnode = new NodeBT(value);
            if ( root == null)
            {
                root = newnode;
            }
            else
            {
                NodeBT current = root;
                while (true)
                {
                    if (value < current.value)
                    {
                        if (current.left == null)
                        {
                            current.left = newnode;
                            break;
                        }
                        current = current.left;
                    }
                    else
                    {
                        if (current.right == null)
                        {
                            current.right = newnode;
                            break;
                        }
                        current = current.right;
                    }
                }

            }

        }

        private string tempoutput;
        public String inOrderTraverse() // helper function
        {
            tempoutput = "";
            inOrderTraverse(root);
            return tempoutput;
        }
        private void inOrderTraverse(NodeBT root)
        {
            if(root != null) { 
                inOrderTraverse(root.left);
                Console.WriteLine(root.value);
                tempoutput += root.value + " ";
                inOrderTraverse(root.right);
            }
        }

        public String PreOrderTraverse() // helper function
        {
            tempoutput = "";
            preOrderTraverse(root);
            return tempoutput;
        }
        private void preOrderTraverse(NodeBT root)
        {
            if (root != null)
            {
                Console.WriteLine(root.value);
                tempoutput += root.value + " ";
                preOrderTraverse(root.left);                
                preOrderTraverse(root.right);
            }
        }

        public String PostOrderTraverse() // helper function
        {
            tempoutput = "";
            PostOrderTraverse(root);
            return tempoutput;
        }
        private void PostOrderTraverse(NodeBT root)
        {
            if (root != null)
            {
                
                PostOrderTraverse(root.left);
                PostOrderTraverse(root.right);
                Console.WriteLine(root.value);
                tempoutput += root.value + " ";
            }
        }

        public NodeBT find(int key)
        {
            return find(root, key);
        }
        public NodeBT find(NodeBT root, int key)
        {
            NodeBT current = root;
            while(current!= null && key != current.value)
            {
                if (key < current.value)
                    current = current.left;
                else
                    current = current.right;

            }
            return current;
        }

        public void delete(int key)
        {
            delete(ref root, key);
        }
        
        private void delete(ref NodeBT root, int key)
        {
            if (root != null)
                if (key < root.value)
                    delete(ref root.left, key);
                else if (key > root.value)
                    delete(ref root.right, key);
                else
                { //key is found -> delete it
                    if (root.left == null) //case 1 or case 2
                        root = root.right;
                    else if (root.right == null) //case 2
                        root = root.left;
                    else
                    {//case 3
                        var value = deletePredecessor(ref root.left);
                        root.value = value;
                    }
                }
        }
        int deletePredecessor(ref NodeBT root)
        {
            if (root.right != null)
                return deletePredecessor(ref root.right);
            else
            { //rightmost node
                int predecessor = root.value;
                root = root.left; //case 1 or case 2
                return predecessor;
            }
        }
    }
}
