// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace Assignment2
{
    namespace NUnit.Tests1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        [TestFixture]
        public class TestClass
        {
            /// <summary>
            /// First Test for HashSetMethod.
            /// </summary>
            [Test]
            public void FirstTestHashSetMethod()
            {
                DistinctIntegers di = new DistinctIntegers();
                List<int> nums = new List<int>() { 1, 1, 1, 1, 1, 1 };
                int res = di.HashSetMethod(nums);
                Assert.That(res, Is.EqualTo(1));
            }

            /// <summary>
            /// Second Test for HashSetMethod.
            /// </summary>
            [Test]
            public void SecondTestHashSetMethod()
            {
                DistinctIntegers di = new DistinctIntegers();
                List<int> nums = new List<int>() { 5, 1, 2, 3, 6 };
                int res = di.HashSetMethod(nums);
                Assert.That(res, Is.EqualTo(5));
            }

            /// <summary>
            /// Third Test for HashSetMethod.
            /// </summary>
            [Test]
            public void ThirdTestHashSetMethod()
            {
                DistinctIntegers di = new DistinctIntegers();
                List<int> nums = new List<int>() { 9, 8, 1, 5, 9, 3, 7, 2, 9, 4, 5, 5, 1, 2, 4, 5, 9, 3, 9, 1, 2, 9, 6, 5, 4, 9, 9, 7, 8, 9, 1, 2, 9, 3, 1, 5, 5, 2, 3, 1, 5, 2, 3, 5, 4, 4, 7, 7, 1, 2, 3, 1, 5, 9 };
                int res = di.HashSetMethod(nums);
                Assert.That(res, Is.EqualTo(9));
            }

            /// <summary>
            /// First Test for StorageComplexityMethod.
            /// </summary>
            [Test]
            public void FirstTestStorageComplexityMethod()
            {
                DistinctIntegers di = new DistinctIntegers();
                List<int> nums = new List<int>() { 1, 1, 1, 1, 1, 1 };
                int res = di.StorageComplexityMethod(nums);
                Assert.That(res, Is.EqualTo(1));
            }

            /// <summary>
            /// Second Test for StorageComplexityMethod.
            /// </summary>
            [Test]
            public void SecondTestStorageComplexityMethod()
            {
                DistinctIntegers di = new DistinctIntegers();
                List<int> nums = new List<int>() { 5, 1, 2, 3, 6 };
                int res = di.StorageComplexityMethod(nums);
                Assert.That(res, Is.EqualTo(5));
            }

            /// <summary>
            /// Third Test for StorageComplexityMethod.
            /// </summary>
            [Test]
            public void ThirdTestStorageComplexityMethod()
            {
                DistinctIntegers di = new DistinctIntegers();
                List<int> nums = new List<int>() { 9, 8, 1, 5, 9, 3, 7, 2, 9, 4, 5, 5, 1, 2, 4, 5, 9, 3, 9, 1, 2, 9, 6, 5, 4, 9, 9, 7, 8, 9, 1, 2, 9, 3, 1, 5, 5, 2, 3, 1, 5, 2, 3, 5, 4, 4, 7, 7, 1, 2, 3, 1, 5, 9 };
                int res = di.StorageComplexityMethod(nums);
                Assert.That(res, Is.EqualTo(9));
            }

            /// <summary>
            /// First Test for SortMethod.
            /// </summary>
            [Test]
            public void FirstTestSortMethod()
            {
                DistinctIntegers di = new DistinctIntegers();
                List<int> nums = new List<int>() { 1, 1, 1, 1, 1, 1 };
                int res = di.SortMethod(nums);
                Assert.That(res, Is.EqualTo(1));
            }

            /// <summary>
            /// Second Test for SortMethod.
            /// </summary>
            [Test]
            public void SecondTestSortMethod()
            {
                DistinctIntegers di = new DistinctIntegers();
                List<int> nums = new List<int>() { 5, 1, 2, 3, 6 };
                int res = di.SortMethod(nums);
                Assert.That(res, Is.EqualTo(5));
            }

            /// <summary>
            /// Third Test for SortMethod.
            /// </summary>
            [Test]
            public void ThirdTestSortMethod()
            {
                DistinctIntegers di = new DistinctIntegers();
                List<int> nums = new List<int>() { 9, 8, 1, 5, 9, 3, 7, 2, 9, 4, 5, 5, 1, 2, 4, 5, 9, 3, 9, 1, 2, 9, 6, 5, 4, 9, 9, 7, 8, 9, 1, 2, 9, 3, 1, 5, 5, 2, 3, 1, 5, 2, 3, 5, 4, 4, 7, 7, 1, 2, 3, 1, 5, 9 };
                int res = di.SortMethod(nums);
                Assert.That(res, Is.EqualTo(9));
            }
        }
    }
}