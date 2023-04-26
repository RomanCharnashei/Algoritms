using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Arrays
{
    public class Revers : IAlgo
    {
        public void DoIt()
        {
            Console.WriteLine(Replacing("Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."));
        }

        public string StackWay(string str)
        {
            char[] chars = str.ToCharArray();

            var stack = new Stack<char>(chars);

            for (int i = 0; i < str.Length; i++)
            {
                chars[i] = stack.Pop();
            }

            return new string(chars);
        }

        public string Replacing(string str)
        {
            char[] chars = str.ToCharArray();          
            int length = chars.Length;
            int leftEdge = length / 2;
            int rightEdge = length - leftEdge;

            for (int left = 0, right = length - 1; left < leftEdge || right > rightEdge; left++, right--)
            {
                char swap = chars[left];
                chars[left] = chars[right];
                chars[right] = swap;
            }

            return new string(chars);
        }
    }
}
