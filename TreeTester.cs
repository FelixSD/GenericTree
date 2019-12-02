using System;
using System.Collections.Generic;
using System.Threading;

namespace GenericTree
{
    class TreeTester
    {
        static void Main(string[] args)
        {
            TreeNode<string> root = new TreeNode<string>(null, "root");
            root.AddChild("child1");
            root.GetChild(0).AddChild("child11");
            root.GetChild(0).GetChild(0).AddChild("child111");
            root.GetChild(0).GetChild(0).AddChild("child112");
            root.AddChild("child2");
            root.GetChild(1).AddChild("child21");
            root.GetChild(1).AddChild("child22");
            root.GetChild(1).GetChild(1).AddChild("child221");
            root.GetChild(1).GetChild(1).GetChild(0).AddChild("child2211");
            Console.WriteLine(root.ToString());
            Thread.Sleep(50000);
        }
    }
}