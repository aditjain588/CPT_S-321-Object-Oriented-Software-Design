// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using NUnit.Framework;

namespace Assignment3
{
    namespace Assignment3Tests
    {
        /// <summary>
        /// Class for testing the FibonoacciTextReader class funcons.
        /// </summary>
        [TestFixture]
        public class FibonacciTextReaderTests
        {
            /// <summary>
            /// first test of FinoacciCalculator function.
            /// </summary>
            [Test]
            public void FirstFibonacciCalculatorTest()
            {
                // TODO: Add your test code here
                FibonacciTextReader f = new FibonacciTextReader(1);
                BigInteger res = f.FibonacciCalculator(1);
                BigInteger ans = 0;
                Assert.That(res, Is.EqualTo(ans));
            }

            /// <summary>
            /// second test of FinoacciCalculator function.
            /// </summary>
            [Test]
            public void SecondtFibonacciCalculatorTest()
            {
                // TODO: Add your test code here
                FibonacciTextReader f = new FibonacciTextReader(1);
                BigInteger res = f.FibonacciCalculator(2);
                BigInteger ans = 1;
                Assert.That(res, Is.EqualTo(ans));
            }

            /// <summary>
            /// third test of FinoacciCalculator function.
            /// </summary>
            [Test]
            public void ThirdFibonacciCalculatorTest()
            {
                // TODO: Add your test code here
                FibonacciTextReader f = new FibonacciTextReader(1);
                BigInteger res = f.FibonacciCalculator(10);
                BigInteger ans = 34;
                Assert.That(res, Is.EqualTo(ans));
            }
        }
    }
}
