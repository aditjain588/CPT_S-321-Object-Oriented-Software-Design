// <copyright file="Form1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Assignment2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Class which fullfills form application requirements.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int res;
            List<int> nums = new List<int>();
            StringBuilder sb = new StringBuilder();
            var rand = new Random();
            for (int i = 0; i < 10000; i++)
            {
                nums.Add(rand.Next(0, 20000));
            }

            DistinctIntegers d = new DistinctIntegers();

            res = d.HashSetMethod(nums);

            sb.Append("1. Hashset method: " + res + " unique numbers \r\n");
            sb.Append("\tO(n) time complexity, as HashSetMethod(nums) is one pass algorithm which traverses the list only once and adds elements to HashSet. \r\n");
            sb.Append("\r\n");

            res = d.StorageComplexityMethod(nums);
            sb.Append("2. O(1) storage method: " + res + " unique numbers \r\n");
            sb.Append("\r\n");

            res = d.SortMethod(nums);
            sb.Append("3. Sorted method: " + res + " unique numbers ");

            this.textBox1.Text = sb.ToString();
        }
    }
}
