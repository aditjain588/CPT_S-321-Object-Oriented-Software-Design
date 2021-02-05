// <copyright file="Node.cs" company="Adit Jain">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BinarySearchTree
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class for making a Node for binary search tree.
    /// </summary>
    public class Node
    {
        private Node rightChild;
        private Node leftChild;
        private int value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="x">Value of Node.</param>
        public Node(int x)
        {
            this.value = x;
            this.LeftChild = null;
            this.RightChild = null;
        }

        /// <summary>
        /// Gets or sets class for making a Node for binary search tree.
        /// </summary>
        public int Value
        {
            get { return this.value; }
            set { value = this.Value; }
        }

        /// <summary>
        /// Gets or sets class for making a Node for binary search tree.
        /// </summary>
        public Node LeftChild
        { get; set; }

        /// <summary>
        /// Gets or sets class for making a Node for binary search tree.
        /// </summary>
        public Node RightChild
        { get; set; }
    }
}
