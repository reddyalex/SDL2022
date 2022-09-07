using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03ThreadedBinaryTree
{
    class NodeBT
    {
        public int value;
        public NodeBT left;
        public NodeBT right;

        public NodeBT(int value)
        {
            this.value = value;
            left = null;
            right = null;
        }
    }
}
