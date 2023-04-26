using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Algoritms.Trees
{
    public class Traverse : IAlgo
    {
        public void DoIt()
        {
            var D = new Node("D");
            var B = new Node("B");
            var E = new Node("E");
            var A = new Node("A");
            var C = new Node("C");

            D.SetLeft(B);
            D.SetRight(E);
            B.SetLeft(A);
            B.SetRight(C);

            Depth(D);

            Console.Read();
        }

        public void Symmetrical(Node node)
        {
            Console.WriteLine($"Enter into {node.Name}.");

            if (node.Left != null) Symmetrical(node.Left);
            if (node.Right != null) Symmetrical(node.Right);

            Console.WriteLine($"{node.Name} was left.");
        }

        public void Depth(Node node)
        {
            var queue = new Queue<Node>();

            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var deqNode = queue.Dequeue();

                Console.WriteLine($"{deqNode.Name} dequeue.");

                if(deqNode.Left != null) queue.Enqueue(deqNode.Left);
                if(deqNode.Right != null) queue.Enqueue(deqNode.Right);
            }
        }
    }
}
