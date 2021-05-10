// <copyright file="FibonacciTextReader.cs" company="Adit Jain">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Assignment3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class for calculating fibonacci series upto n and using overriden textreader methods ReadLine() and ReadToEnd() to output on WinForms.
    /// </summary>
    public class FibonacciTextReader : System.IO.TextReader
    {
        private int numberLines;
        private int currLine = 1;

        /// <summary>
        /// Initializes a new instance of the <see cref="FibonacciTextReader"/> class.
        /// </summary>
        /// <param name="n">Total number of available lines. </param>
        public FibonacciTextReader(int n)
        {
            this.numberLines = n;
        }

        /// <summary>
        /// Calculates the fibonacci number of nth number.
        /// </summary>
        /// <param name="num">number whose finonacci number is required.</param>
        /// <returns>Fibonacci number. </returns>
        public BigInteger FibonacciCalculator(int num)
        {
            BigInteger firstNum = 0, secondNum = 1, res = 0;
            if (num == 1)
            {
                return firstNum;
            }
            else if (num == 2)
            {
                return secondNum;
            }

            for (int i = 3; i <= num; i++)
            {
                res = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = res;
            }

            return secondNum;
        }

        /// <summary>
        /// My implementation of ReadLine() function.
        /// </summary>
        /// <returns>Next line of object which is being read. </returns>
        public override string ReadLine()
        {
            string res;
            if (this.currLine <= this.numberLines)
            {
                res = this.FibonacciCalculator(this.currLine).ToString();
                this.currLine += 1;
                return res;
            }

            return null;
        }

        /// <summary>
        /// My implementation of ReadToEnd() function.
        /// </summary>
        /// <returns>concatenated contents of object which is being read. </returns>
        public override string ReadToEnd()
        {
            StringBuilder sb = new StringBuilder();
            string res;
            while (this.currLine < this.numberLines)
            {
                res = this.FibonacciCalculator(this.currLine).ToString();
                this.currLine += 1;
                sb.Append(res + "\r\n");
            }

            return sb.ToString();
        }
    }
}
