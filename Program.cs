using NodeDef;
using Exam;
namespace Laba2_Alg
{
    class Program
    {
        static void Main()
        {
            NodeWork<int> stack = new NodeWork<int>();
            stack.Add(5);
            stack.Add(2);
            stack.Add(8);
            stack.Add(9);
            stack.Add(6);
            stack.Add(1);

            Init_Menu.Menu(stack);

        }
    }
}