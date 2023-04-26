using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Algoritms.Trees
{
    public class Node
    {
        public Node(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public string Name { get; }
        public Node? Left { get; private set; }
        public Node? Right { get; private set; }

        public void SetLeft(Node node)
        {
            Left = node ?? throw new ArgumentNullException(nameof(node));
        }

        public void SetRight(Node node)
        {
            Right = node ?? throw new ArgumentNullException(nameof(node));
        }
    }
}
