// <copyright file="Program.cs" company="Adit jain">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BinarySearchTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Implements binary search tree from data provided by user.
    /// </summary>
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a collection of numbers in the range [0,100], seprated by spaces: ");
            var userInput = Console.ReadLine();
            var tempArray = userInput.Split(' ');

            string[] inputArray = new HashSet<string>(tempArray).ToArray(); // removing duplicates
            BST firstTree = new BST();
            for (int i = 0; i < inputArray.Length; i++)
            {
               firstTree.Insert(int.Parse(inputArray[i]));
            }

            firstTree.TreeStatistcis();
        }
    }
}
