// <copyright file="BST.cs" company="Adit Jain">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BinarySearchTree
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class for implementing Binary search tree, contains the methods: Insert, TreeContents, TreeLevel, NodesCount, TreeStatistics.
    /// </summary>
    internal class BST
    {
        private Node root;

        /// <summary>
        /// Initializes a new instance of the <see cref="BST"/> class.
        /// </summary>
        public BST()
        {
            this.root = null;
        }

        /// <summary>
        /// Gets or sets initializes a new instance of the Node class.
        /// </summary>
        public Node Root
        {
            get { return this.root; }
            set { this.root = this.Root; }
        }

        /// <summary>
        /// Initializes a new instance of the Node class and inserts it into binary search tree by following the rules of BST.
        /// </summary>
        /// <param name="val"> value of node which is inserted into the tree. </param>
        public void Insert(int val)
        {
            Node temp = new Node(val)
            {
                Value = val,
            };
            if (this.root == null)
            {
                this.root = temp;
            }
            else
            {
                Node curr = this.root;
                Node parent;
                while (true)
                {
                    parent = curr;
                    if (val < curr.Value)
                    {
                        curr = curr.LeftChild;
                        if (curr == null)
                        {
                            parent.LeftChild = temp;
                            break;
                        }
                    }
                    else
                    {
                        curr = curr.RightChild;
                        if (curr == null)
                        {
                            parent.RightChild = temp;
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Recursively traverses the tree and prints the contents in ascending order.
        /// </summary>
        /// <param name="root"> root of a tree whose contents are to be printed. </param>
        public void TreeContents(Node root)
        {
                if (root != null)
                {
                    this.TreeContents(root.LeftChild);
                    Console.Write(root.Value + " ");
                    this.TreeContents(root.RightChild);
                }
        }

        /// <summary>
        /// Recursively traverse the tree and computes the level.
        /// </summary>
        /// <returns>Level of a tree.</returns>
        public int TreeLevel(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            int left = this.TreeLevel(root.LeftChild);
            int right = this.TreeLevel(root.RightChild);

            if (left > right)
            {
                return left + 1;
            }
            else
            {
                return right + 1;
            }
        }

        /// <summary>
        /// Recursicvely traverses the tree and counts the number of nodes.
        /// </summary>
        /// <param name="temp"> root of tree whose number of nodes have to be counted. </param>
        /// <returns> Number of nodes.</returns>
        public int NodesCount(Node temp)
        {
            int count = 1;
            if (temp == null)
            {
                return 0;
            }

            count += this.NodesCount(temp.LeftChild);
            count += this.NodesCount(temp.RightChild);
            return count;
        }

        /// <summary>
        /// Prints all the required statistics of the tree such as tree contents, number of nodes, number of level, minimum level with n nodes.
        /// </summary>
        public void TreeStatistcis()
        {
            Console.Write("Tree contents: ");
            this.TreeContents(this.root);
            Console.WriteLine();
            Console.WriteLine("Tree Statistics: ");
            Console.WriteLine(" Number of nodes: " + this.NodesCount(this.root));
            Console.WriteLine(" Height of tree is: " + this.TreeLevel(this.root));
            Console.WriteLine(" Minimum number of levels that a tree with " + this.NodesCount(this.root) + " nodes could have = " + Math.Floor(Math.Log2(this.NodesCount(this.root)) + 1));
        }
    }
}
