// <copyright file="DistinctIntegers.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Assignment2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class uses three different methods to calculate distict integers in a list.
    /// </summary>
    public class DistinctIntegers
    {
        /// <summary>
        /// Function uses HashSet to remove duplicates in a list.
        /// </summary>
        /// <param name="nums">List of integers. </param>
        /// <returns>Number of distinct integers in a HashSet. </returns>
        public int HashSetMethod(List<int> nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            return set.Count;
        }

        /// <summary>
        /// Function removes distinct integers from list in O(1) space.
        /// </summary>
        /// <param name="nums">List of integers. </param>
        /// <returns>Number of distinct integers in nums. </returns>
        public int StorageComplexityMethod(List<int> nums)
        {
            int start = 0; // variable to traverse list.
            int end = 0; // variable to traverse list.
            bool flag = false; // variable to check if an element was removed from list or not. 
            while (start < nums.Count() - 1)
            {
                int ele = nums[start];
                while (end < nums.Count())
                {
                    // remove element at nums[end] if more then one occurence and change flag to true.
                    if ((ele == nums[end]) && (end != start))
                    {
                        nums.RemoveAt(end);
                        flag = true;
                    }
                    else
                    {
                        // if not the same element then just go to next element in list.
                        end += 1;
                    }
                }

                if (flag == false)
                {
                    // if flag=false means no elements were removed, then increment start otherwise no need to increase start, because element was removed means nums.Count was already decreased meaning start is pointing at next element in list.
                    start += 1;
                }

                flag = false;
                end = 0;
            }

            return nums.Count;
        }

        /// <summary>
        /// Function removes distinct integers in list using sort method and in O(n) time.
        /// </summary>
        /// <param name="nums">List of integers. </param>
        /// <returns>Number of distinct integers in nums. </returns>
        public int SortMethod(List<int> nums)
        {
            nums.Sort();
            int start = 0;
            int end = 1;

            while (start < nums.Count() - 1)
            {
                if (nums[start] == nums[end])
                {
                    // if start and end are pointing to same value, remove element at start, and no need to increment variables in this case.
                    nums.RemoveAt(start);
                }
                else
                {
                    // if start and end pointing to distinct variables, then no need to remove, just increment.
                    start++;
                    end++;
                }
            }

            return nums.Count();
        }
    }
}
