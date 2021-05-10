// <copyright file="ProductStock.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace LocalStoreDesktopApplication
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// ....
    /// </summary>
    public class ProductStock
    {
        /// <summary>
        /// Searches the database for a list of strings and returns the arraylist which contains the matched results.
        /// </summary>
        /// <param name="dict">dictionary of database. </param>
        /// <param name="substr">list of substrings to be searched. </param>
        /// <param name="operation">operation using which serach is to be performed (AND | OR).</param>
        /// <returns>list. </returns>
        public ArrayList Search(Dictionary<string, Tuple<string, int, string>> dict, string[] substr, string operation)
        {
            var res = new ArrayList();
            foreach (var item in dict)
            {
                if (substr[0] == string.Empty)
                {
                    // if empty string is entered then just add the item in result list
                    res.Add(item);
                }
                else
                {
                    if (operation == "OR")
                    {
                        // Traverses database and if any item matches any of the contents of substr array, then it is added to res arraylist.
                        for (int i = 0; i < substr.Length; i++)
                        {
                            if (item.Key.Contains(substr[i]) || item.Value.Item1.Contains(substr[i]) || item.Value.Item3.Contains(substr[i]))
                            {
                                if (!res.Contains(item))
                                {
                                    res.Add(item);
                                }
                            }
                        }
                    }
                    else if (operation == "AND")
                    {
                        bool flag = true;

                        // Traverses database and if all the items of substr list matches an item, then that item is added to res arraylist.
                        for (int i = 0; i < substr.Length; i++)
                        {
                            if (!item.Key.Contains(substr[i]) && !item.Value.Item1.Contains(substr[i]) && !item.Value.Item3.Contains(substr[i]))
                            {
                                flag = false;
                            }
                        }

                        if (flag == true)
                        {
                            if (!res.Contains(item))
                            {
                                res.Add(item);
                            }
                        }
                    }
                }
            }

            if (res.Count == 0)
            {
                Console.WriteLine("No items found ");
            }
            else
            {
                Console.WriteLine("ID " + "Name " + "Quantity " + "Description");
                Console.WriteLine(string.Empty);

                // Show user the search results.
                foreach (var item in res)
                {
                    Console.WriteLine(item);
                    Console.WriteLine(string.Empty);
                }
            }

            return res;
        }

        /// <summary>
        /// Saves the results of last search in a file located in "searches" folder, with file name as the time and date of search.
        /// </summary>
        /// <param name="res">stores the list of last search. </param>
        /// <param name="fileName">File name of the file. </param>
        public void SaveSearch(ArrayList res, string fileName)
        {
            string dir = @"C:\Users\imadi\source\repos\MidTerm\MidTerm\bin\Debug\netcoreapp3.1\searches\";
            Console.WriteLine(fileName);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            dir = dir + fileName + ".txt";
            using var fs = new StreamWriter(dir);
            for (int i = 0; i < res.Count; i++)
            {
                fs.WriteLine(res[i]);
            }
        }

        /// <summary>
        /// Traverses the database, purchases and updates the quantity of items less then n.
        /// </summary>
        /// <param name="dict">dictionary of database. </param>
        /// <param name="n">number below which the items needs to be purchased. </param>
        public void Restock(Dictionary<string, Tuple<string, int, string>> dict, int n)
        {
            var res = new ArrayList();

            // Traverse through database and items whose quantity is less then n, are stored in res ArrayList.
            foreach (var item in dict)
            {
                if (item.Value.Item2 < n)
                {
                    res.Add(item);
                }
            }

            Console.WriteLine("Items with quantity less then " + n + " are: ");
            Console.WriteLine("ID " + "Name " + "Quantity " + "Description");
            Console.WriteLine(string.Empty);

            // Show user the items whose quantity is less then n.
            foreach (var i in res)
            {
                Console.WriteLine(i);
                Console.WriteLine(string.Empty);
            }

            int menuChoice = 0;
            Console.WriteLine(string.Empty);
            menuChoice = this.AskUserRestock();
            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine("Yes selected");
                    Console.WriteLine("ID " + "Name " + "Quantity");
                    foreach (var i in res)
                    {
                        Console.WriteLine(i);
                        Console.WriteLine(string.Empty);
                    }

                    // Traverses through database and asks user the number of additional items to be purchased for each item whose quantity is less then n.
                    for (var i = 0; i < dict.Count; i++)
                    {
                        var k = dict.ElementAt(i).Key;
                        if (dict.ElementAt(i).Value.Item2 < n)
                        {
                            Console.WriteLine("How many additional items needs to be purchased for " + dict.ElementAt(i) + " item");
                            int numItem = 0;
                            numItem = this.AskUserNumItems();
                            dict[k] = new Tuple<string, int, string>(dict.ElementAt(i).Value.Item1, numItem + dict.ElementAt(i).Value.Item2, dict.ElementAt(i).Value.Item3);
                        }
                    }

                    Console.WriteLine(string.Empty);
                    Console.WriteLine("Purcahse successfull");
                    Console.WriteLine("Updated databse: ");
                    Console.WriteLine("ID " + "Name " + "Quantity " + "Description");

                    // Displays the updated database.
                    foreach (var item in dict)
                    {
                        Console.WriteLine(item);
                        Console.WriteLine(string.Empty);
                    }

                    break;
                case 2:
                    Console.WriteLine("No selected ");
                    int choice = 0;
                    choice = this.AskUserRestockSecondCase(choice);
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the value of new N ");
                            int newN = int.Parse(Console.ReadLine());

                            // Call the Restock function again with new value of n
                            this.Restock(dict, newN);
                            break;

                        case 2:
                            // return to main menu
                            break;
                    }

                    break;
            }
        }

        /// <summary>
        /// Asks user which which operation is to be performed.
        /// </summary>
        /// <returns>1 or 2. </returns>
        public int AskUserRestock()
        {
            int menuChoice;
            Console.WriteLine("Would you like to restock all the items?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            menuChoice = int.Parse(Console.ReadLine());
            return menuChoice;
        }

        /// <summary>
        /// Asks user the number of additional items to be purcahsed.
        /// </summary>
        /// <returns>Number of items to be purcahsed. </returns>
        public int AskUserNumItems()
        {
            int numItem = int.Parse(Console.ReadLine());
            return numItem;
        }

        /// <summary>
        /// Asks user which which operation is to be performed.
        /// </summary>
        /// <param name="choice">choice made by user about what to do next. </param>
        /// <returns>return 1 or 2. </returns>
        public int AskUserRestockSecondCase(int choice)
        {
            Console.WriteLine("1. Would you like to change N?");
            Console.WriteLine("2. Would you like to return to main menu?");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
