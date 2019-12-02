using System;
using System.Collections.Generic;

namespace GenericTree
{
    class TreeNode<T>
    {
        private TreeNode<T> parent;
        private List<TreeNode<T>> children;
        private T element;

        public TreeNode(TreeNode<T> parent, T element)
        {
            this.parent = parent;
            this.children = new List<TreeNode<T>>();
            this.element = element;
        }

        public void SetParent(TreeNode<T> parent)
        {
            this.parent = parent;
        }

        public TreeNode<T> GetParent()
        {
            return this.parent;
        }

        public List<TreeNode<T>> GetChildren()
        {
            return this.children;
        }

        public TreeNode<T> GetChild(int index)
        {
            return this.children[index];
        }

        public void SetElement(T element)
        {
            this.element = element;
        }

        public T GetElement()
        {
            return this.element;
        }

        public void AddChild(T childElement)
        {
            children.Add(new TreeNode<T>(this, childElement));
        }

        public void PrintPartialTree()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return ToStringRecursive(0);
        }

        public string ToStringRecursive(int n)
        {
            string treeString = "";
            for(int i = 0; i < n; i++)
            {
                treeString += ">";
            }
            treeString += element.ToString();
            if(children.Count != 0)
            {
                for(int j = 0; j < children.Count; j++)
                {
                    treeString += "\n";
                    treeString += children[j].ToStringRecursive(n + 1);
                }
            }
            return treeString;
        }
    }
}