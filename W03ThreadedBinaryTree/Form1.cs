using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W03ThreadedBinaryTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinarySearchTree bst = new BinarySearchTree();

            bst.insert(7);
            bst.insert(5);
            bst.insert(3);
            bst.insert(19);
            bst.insert(27);
            bst.insert(4);
            bst.delete(7);
            //int a = 10;

            textBox1.Text =  bst.inOrderTraverse();
            textBox2.Text =  bst.PreOrderTraverse();
            textBox3.Text =  bst.PostOrderTraverse();

            var x = bst.find(19);
            int a = 10;
        }
    }
}
